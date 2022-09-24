global using Pantheon.Bases.BaseBlazorShared.BaseEtms;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Shared.Etms
{
    public class T1Karyawan : pthBaseT1Karyawan
    {
        [ForeignKey("IdJabatan")]
        public T0Jabatan? T0Jabatan { get; set; }
        [ForeignKey("IdDivisiPerusahaan")]
        public T0DivisiPerusahaan? T0DivisiPerusahaan { get; set; }
    }
}
