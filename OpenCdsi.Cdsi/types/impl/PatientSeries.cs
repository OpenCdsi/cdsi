﻿namespace OpenCdsi.Cdsi
{
    public class PatientSeries : IPatientSeries
    {
        public PatientSeriesStatus Status { get; set; }
        public antigenSupportingDataSeries Series { get; internal set; }
        public string Antigen { get => Series.targetDisease; }
        public string Name { get => Series.seriesName; }
        public PatientSeriesType SeriesType { get => Enum.TryParse<PatientSeriesType>(Series.seriesType); }
        public IList<ITargetDose> TargetDoses { get; internal set; }
    }
}
