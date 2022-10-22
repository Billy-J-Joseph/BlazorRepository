namespace BlazorApp1.Shared.Etms;
public class T9Privileges : pthT9Privileges
{

    [ForeignKey("IdKaryawan")]
    public  T1Karyawan? T1Karyawan { get; set; }
    [ForeignKey("IdForm")]
    public T0Form? T0Form { get; set; }
    [ForeignKey("IdCompany")]
    public T0Company? T0Company { get; set; }
}
