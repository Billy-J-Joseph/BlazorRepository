using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Shared.Etms;
public class T7OrderPenjualan : pthT7OrderPenjualan
{
    [ForeignKey("IdOrderPenjualan")]
    public T6OrderPenjualan? T6OrderPenjualan { get; set; }
    [ForeignKey("IdOperator")]
    public T1Karyawan? T1Karyawan_Operator { get; set; }
}
