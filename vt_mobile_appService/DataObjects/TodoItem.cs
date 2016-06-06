using Microsoft.Azure.Mobile.Server;

namespace vt_mobile_appService.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}