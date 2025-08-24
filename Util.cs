using System.Drawing.Drawing2D;

namespace AgendaWF;
public class Util
{
    public static int Verifica_Int(string txt)
    {
        if (string.IsNullOrWhiteSpace(txt)) return 0;

        int valor;
        if (int.TryParse(txt.Trim(), out valor))
            return valor;

        return 0;
    }

    public static string Configura_String(string txt)
    {
        string str = txt;

        str = str.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");

        return str;
    }

    public static void ArredondarBotao(Button btn, int raio)
    {
        var path = new GraphicsPath();
        path.AddArc(0, 0, raio, raio, 180, 90);
        path.AddArc(btn.Width - raio, 0, raio, raio, 270, 90);
        path.AddArc(btn.Width - raio, btn.Height - raio, raio, raio, 0, 90);
        path.AddArc(0, btn.Height - raio, raio, raio, 90, 90);
        path.CloseAllFigures();
        btn.Region = new Region(path);
    }
}
