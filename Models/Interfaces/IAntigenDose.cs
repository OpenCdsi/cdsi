﻿namespace Cdsi
{
    /// <summary>
    /// Represents an antigen dose administered to a patient.
    /// </summary>
    /// <remarks>Created as a result of the organize-patient-history procedure.</remarks>
    public interface IAntigenDose
    {
        string AntigenName { get; }
        string EvaluationReason { get; set; }
        EvaluationStatus EvaluationStatus { get; set; }
        IVaccineDose AdministeredDose { get; } // prefer composition over inheritence
    }
}