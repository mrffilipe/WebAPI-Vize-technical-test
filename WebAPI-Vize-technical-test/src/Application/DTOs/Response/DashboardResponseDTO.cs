﻿using WebAPI_Vize_technical_test.src.Domain;

namespace WebAPI_Vize_technical_test.src.Application
{
    public record DashboardResponseDTO
    {
        public DashboardItemVO Material { get; init; }
        public DashboardItemVO Service { get; init; }

        public DashboardResponseDTO(DashboardItemVO material, DashboardItemVO service)
        {
            Material = material ?? throw new ArgumentNullException(nameof(material), "Material cannot be null");
            Service = service ?? throw new ArgumentNullException(nameof(service), "Service cannot be null");
        }
    }
}