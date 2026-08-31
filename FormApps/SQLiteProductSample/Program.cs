namespace SQLiteProductSample;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            //SQLiteデータベースを初期化する
            //products.dbファイルが存在しない場合は作成される
            //Productsテーブルが存在しない場合だけ作成される
            Database.Initialize();
            Application.Run(new Form1());
        }
        catch (Exception ex)
        {
            MessageBox.Show(
                $"アプリケーションの起動に失敗しました。\n\n{ex.Message}",
                "起動エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
