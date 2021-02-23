using System;
using System.Collections.Generic;
using System.Windows;

namespace CV19.Models
{
    internal class PlaseInfo
    {
        public string Name { get; set; }
        public Point Location { get; set; }
        public IEnumerable<ConfirmedCount> Counts { get; set; }
    }
    internal class CountryInfo : PlaseInfo
    {
        public IEnumerable<ProvinceInfo> ProvinceCoints { get; set; }
    }
    internal class ProvinceInfo : PlaseInfo
    {

    }
    internal struct ConfirmedCount
    {
        public DateTime Data { get; set; }
        public int Count { get; set; }
    }
    internal struct DataPoint
    {
        public double XValue { get; set; }
        public double YValue { get; set; }
    }
}
