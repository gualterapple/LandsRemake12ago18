using System.Globalization;

namespace Lands.Interfaces
{
    public interface ILocalize
    {
        CultureInfo GetCultureInfo();
        void SetLocale(CultureInfo ci);
    }
}
