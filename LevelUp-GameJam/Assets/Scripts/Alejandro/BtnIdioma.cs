using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    private int currentLocaleIndex = 0;

    public void ToggleLanguage()
    {
        // Alternar entre los dos idiomas (suponiendo que solo tienes 2 idiomas en la lista)
        currentLocaleIndex = (currentLocaleIndex + 1) % 2;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[currentLocaleIndex];
    }
}

