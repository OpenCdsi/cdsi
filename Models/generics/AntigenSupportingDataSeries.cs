﻿using System.Collections.Generic;
using System.Linq;
using Cdsi.SupportingDataLibrary;
using Enum = Utility.Enum;

namespace Cdsi
{
    public static partial class AntigenSupportingDataSeries
    {
        public static IPatientSeries ToModel(this antigenSupportingDataSeries asds)
        {
            var series = new PatientSeries()
            {
                AntigenName = asds.targetDisease,
                SeriesName = asds.seriesName,
                Status = PatientSeriesStatus.NotComplete,
                SeriesType = Enum.TryParse<PatientSeriesType>(asds.seriesType)
            };

            series.TargetDoses.AddAll(asds.seriesDose.Select(x => new TargetDose()
            {
                DoseName = x.doseNumber,
                Status = TargetDoseStatus.NotSatisfied
            }));

            return series;

        }
<<<<<<< HEAD
        public static IPatientSeries ToModel(this antigenSupportingDataSeries asds, IEnumerable<IAntigenDose> ad)
=======
        public static PatientSeries ToModel(this antigenSupportingDataSeries asds, IEnumerable<IAntigenDose> ad)
>>>>>>> 05cb7d9137818dc5660e777ea8927f5fe5039fba
        {
            var series = asds.ToModel();

            series.AntigenDoses.AddAll(ad.Where(x => x.AntigenName == asds.targetDisease));
            return series;
        }
    }
}
