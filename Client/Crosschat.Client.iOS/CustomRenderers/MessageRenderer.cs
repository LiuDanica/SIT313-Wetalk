using WeTalk.Client.iOS.CustomRenderers;
using WeTalk.Client.ViewModels;
using WeTalk.Client.Views.Controls;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MessageViewCell), typeof(MessageRenderer))]

namespace WeTalk.Client.iOS.CustomRenderers
{
    public class MessageRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableView tv)
        {
            var textVm = item.BindingContext as TextMessageViewModel;
            if (textVm != null)
            {
                string text = textVm.ImageId.HasValue ? "<IOS client doesn't support image messages yet ;(>" : (textVm.IsMine ? "Me" : textVm.AuthorName) + ": " + textVm.Text;
                var chatBubble = new ChatBubble(!textVm.IsMine, text);
                return chatBubble.GetCell(tv);
            }
            return base.GetCell(item, tv);
        }
    }
}