using System;
using System.Collections.Generic;

namespace Domain.Entities;

public class Order
{
    // Propiedad que identifica la orden; se usa en lugar de campos públicos para cumplir buenas prácticas
    public int Id { get; set; }

    // Nombre del cliente que genera la orden; marcado como requerido para garantizar un valor válido
    public required string CustomerName { get; set; }

    // Nombre del producto solicitado; también requerido para evitar valores nulos no deseados
    public required string ProductName { get; set; }

    // Cantidad de unidades del producto que se están ordenando
    public int Quantity { get; set; }

    // Precio por unidad, utilizado junto con la cantidad para sacar el total
    public decimal UnitPrice { get; set; }

    public void CalculateTotalAndLog()
    {
        // Cálculo del total multiplicando unidades por el precio y envío del resultado al sistema de log
        var total = Quantity * UnitPrice;
        Infrastructure.Logging.Logger.Log("Total (maybe): " + total);
    }
}
  
