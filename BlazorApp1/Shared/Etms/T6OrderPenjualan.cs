using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Shared.Etms;
public class T6OrderPenjualan : pthT6OrderPenjualan
{
    public List<T7OrderPenjualan>? ListT7OrderPenjualan { get; set; }
}
