using System;
using System.Windows.Forms;
using System.Drawing;
using WixToolset.Dtf.WindowsInstaller;

namespace CustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult CustomAction1(Session session)
        {
            session.Log("Begin CustomAction1");

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult ShowUninstallMessage(Session session)
        {
            try
            {
                session.Log("Begin ShowUninstallMessage");
                
                // メッセージボックスのオーナーウィンドウを作成
                Form dummyForm = new Form();
                dummyForm.StartPosition = FormStartPosition.Manual;
                
                // 画面の中央から少し右下にずらした位置を計算
                int offsetX = 100;  // 右に100ピクセル
                int offsetY = 50;   // 下に50ピクセル
                dummyForm.Location = new Point(
                    (Screen.PrimaryScreen.WorkingArea.Width - dummyForm.Width) / 2 + offsetX,
                    (Screen.PrimaryScreen.WorkingArea.Height - dummyForm.Height) / 2 + offsetY
                );
                
                MessageBox.Show(dummyForm, "Uninstallation completed successfully.", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dummyForm.Dispose();
                
                return ActionResult.Success;
            }
            catch (Exception ex)
            {
                session.Log($"Error in ShowUninstallMessage: {ex.Message}");
                return ActionResult.Failure;
            }
        }
    }
}
