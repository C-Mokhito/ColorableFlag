using BrokeProtocol.API;
using BrokeProtocol.Collections;
using BrokeProtocol.Entities;
using ColorSystem;
using System.Linq;

namespace ColorableFlag
{
    public class FlagManager : PlayerEvents
    {
        [CustomTarget]
        public void FlagRecolor(ShEntity entity, ShPlayer player)
        {
            string menuID = $"colorable-flag-{entity.ID}";
            player.svPlayer.SendInputMenu("Please choose a color (in hexadecimal format)", player.ID, menuID, 7);
        }

        public override bool SubmitInput(ShPlayer player, int targetID, string id, string input)
        {
            if (!id.StartsWith("colorable-flag-")) return true;

            string entityID_STR = id.Replace("colorable-flag-", "");
            if (!int.TryParse(entityID_STR, out int entityID)) return true;

            ShEntity entity = EntityCollections.Entities.FirstOrDefault(e => e.ID == entityID);
            if (entity == null) return false;

            if (UnityEngine.ColorUtility.TryParseHtmlString(input, out UnityEngine.Color UnityColor))
            {
                byte r = (byte)(UnityColor.r * 255);
                byte g = (byte)(UnityColor.g * 255);
                byte b = (byte)(UnityColor.b * 255);

                var ColorSystem = new Color(r, g, b);
                entity.SetColor1(ColorSystem);
                player.svPlayer.SendGameMessage("The flag color has been changed.");
            }
            else
            {
                player.svPlayer.SendGameMessage("The color must be specified in hexadecimal only.");
            }

            return true;
        }
    }
}
