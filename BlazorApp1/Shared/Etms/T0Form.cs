namespace BlazorApp1.Shared.Etms;
public class T0Form : pthT0Form
{
    [ForeignKey("IdCreator")]
    public T1Karyawan? T1Karyawan_Creator { get; set; }
    [ForeignKey("IdOperator")]
    public T1Karyawan? T1Karyawan_Operator { get; set; }
    [ForeignKey("IdValidator")]
    public T1Karyawan? T1Karyawan_Validator { get; set; }
    public List<T9Privileges>? ListT9Privileges { get; set; }
}
