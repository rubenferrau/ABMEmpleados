using System;
using System.Collections.Generic;

namespace ABMEmpleados.Models;

public partial class Empleados
{
    public int Id { get; set; }

    public string? Dni { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Telefono { get; set; }

    public string? Mail { get; set; }

    public DateOnly? FechaIngreso { get; set; }

    public string? Puesto { get; set; }

    public double? Salario { get; set; }
}
