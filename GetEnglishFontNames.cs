class GetEnglishFontNames
{
    static void Main()
    {
        var col = new System.Drawing.Text.InstalledFontCollection();
        var fonts = col.Families;
        var lcid = System.Globalization.CultureInfo.GetCultureInfo("en-US").LCID;
        foreach (var font in fonts)
        {
            System.Console.WriteLine(font.GetName(lcid));
        }
    }
}
