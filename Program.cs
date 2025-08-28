using System;
using System.Collections.Generic;

public class Balon
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public decimal Precio { get; set; }
}

public class Cliente
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
}

public class Factura
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public Cliente Cliente { get; set; } = new Cliente(
