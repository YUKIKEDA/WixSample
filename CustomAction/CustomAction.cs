using System;
using System.Windows.Forms;
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
                MessageBox.Show(session["UninstallCompleteMessage"], "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
