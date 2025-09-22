using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Tyuiu.GalimovAA.Sprint7.Project.V7.Lib
{
    public class DataService
    {
        public class Apartment
        {
            public int EntranceNumber { get; set; }
            public int ApartmentNumber { get; set; }
            public double TotalArea { get; set; }
            public double LivingArea { get; set; }
            public int RoomsCount { get; set; }
            public string TenantName { get; set; }
            public DateTime RegistrationDate { get; set; }
            public int FamilyMembers { get; set; }
            public int ChildrenCount { get; set; }
            public bool HasDebt { get; set; }
            public string Notes { get; set; }
        }

        private List<Apartment> apartments;
        private string dataFilePath;

        public DataService(string filePath)
        {
            apartments = new List<Apartment>();
            dataFilePath = filePath;
            LoadData();
        }

        public void LoadData()
        {
            if (File.Exists(dataFilePath))
            {
                apartments.Clear();
                var lines = File.ReadAllLines(dataFilePath);

                // Пропускаем заголовок, если файл не пустой
                if (lines.Length > 1)
                {
                    foreach (var line in lines.Skip(1))
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        var values = line.Split(';');
                        if (values.Length >= 11)
                        {
                            try
                            {
                                apartments.Add(new Apartment
                                {
                                    EntranceNumber = int.Parse(values[0]),
                                    ApartmentNumber = int.Parse(values[1]),
                                    TotalArea = double.Parse(values[2]),
                                    LivingArea = double.Parse(values[3]),
                                    RoomsCount = int.Parse(values[4]),
                                    TenantName = values[5],
                                    RegistrationDate = DateTime.Parse(values[6]),
                                    FamilyMembers = int.Parse(values[7]),
                                    ChildrenCount = int.Parse(values[8]),
                                    HasDebt = bool.Parse(values[9]),
                                    Notes = values[10]
                                });
                            }
                            catch
                            {
                                // Пропускаем некорректные строки
                                continue;
                            }
                        }
                    }
                }
            }
        }

        public void SaveData()
        {
            var lines = new List<string> { "Entrance;Apartment;TotalArea;LivingArea;Rooms;Tenant;Registration;FamilyMembers;Children;HasDebt;Notes" };
            lines.AddRange(apartments.Select(a =>
                $"{a.EntranceNumber};{a.ApartmentNumber};{a.TotalArea};{a.LivingArea};{a.RoomsCount};{a.TenantName};{a.RegistrationDate:yyyy-MM-dd};{a.FamilyMembers};{a.ChildrenCount};{a.HasDebt};{a.Notes}"));

            File.WriteAllLines(dataFilePath, lines);
        }

        public void AddApartment(Apartment apartment)
        {
            apartments.Add(apartment);
            SaveData();
        }

        public void UpdateApartment(int index, Apartment apartment)
        {
            if (index >= 0 && index < apartments.Count)
            {
                apartments[index] = apartment;
                SaveData();
            }
        }

        public void DeleteApartment(int index)
        {
            if (index >= 0 && index < apartments.Count)
            {
                apartments.RemoveAt(index);
                SaveData();
            }
        }

        public List<Apartment> GetAllApartments() => apartments;

        public List<Apartment> SearchApartments(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return apartments;

            return apartments.Where(a =>
                a.ApartmentNumber.ToString().Contains(searchTerm) ||
                (a.TenantName != null && a.TenantName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                (a.Notes != null && a.Notes.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))).ToList();
        }

        public List<Apartment> FilterByDebt(bool hasDebt) => apartments.Where(a => a.HasDebt == hasDebt).ToList();

        public List<Apartment> SortBy(string field, bool ascending = true)
        {
            if (!apartments.Any()) return apartments;

            return field.ToLower() switch
            {
                "apartment" => ascending ?
                    apartments.OrderBy(a => a.ApartmentNumber).ToList() :
                    apartments.OrderByDescending(a => a.ApartmentNumber).ToList(),
                "area" => ascending ?
                    apartments.OrderBy(a => a.TotalArea).ToList() :
                    apartments.OrderByDescending(a => a.TotalArea).ToList(),
                "tenant" => ascending ?
                    apartments.OrderBy(a => a.TenantName).ToList() :
                    apartments.OrderByDescending(a => a.TenantName).ToList(),
                _ => apartments
            };
        }

        public Dictionary<string, object> GetStatistics()
        {
            var stats = new Dictionary<string, object>
            {
                ["TotalApartments"] = apartments.Count,
                ["DebtCount"] = apartments.Count(a => a.HasDebt),
                ["TotalResidents"] = apartments.Sum(a => a.FamilyMembers),
                ["TotalChildren"] = apartments.Sum(a => a.ChildrenCount)
            };

            // Добавляем статистику по площади только если есть квартиры
            if (apartments.Any())
            {
                stats["TotalArea"] = apartments.Sum(a => a.TotalArea);
                stats["AverageArea"] = apartments.Average(a => a.TotalArea);
                stats["MaxArea"] = apartments.Max(a => a.TotalArea);
                stats["MinArea"] = apartments.Min(a => a.TotalArea);
            }
            else
            {
                stats["TotalArea"] = 0.0;
                stats["AverageArea"] = 0.0;
                stats["MaxArea"] = 0.0;
                stats["MinArea"] = 0.0;
            }

            return stats;
        }

        public Dictionary<int, int> GetApartmentsByEntrance()
        {
            if (!apartments.Any())
                return new Dictionary<int, int>();

            return apartments
                .GroupBy(a => a.EntranceNumber)
                .OrderBy(g => g.Key)
                .ToDictionary(g => g.Key, g => g.Count());
        }
    }
}