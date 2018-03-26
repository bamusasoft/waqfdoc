using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WDM.DocTrack.UiTemplates
{
    public class FollowingContentTemplateSelector:DataTemplateSelector
    {
        public DataTemplate DocForwardTemplate { get; set; }
        public DataTemplate DocResponseTemplate { get; set; }
        public DataTemplate DocAppointmentsTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            string value = item as string;
            if (value != null)
            {
                if(value == "احالة")
                {
                    return DocForwardTemplate;
                }
                else if(value == "صادر")
                {
                    return DocResponseTemplate;
                }
                else if(value == "موعد")
                {
                    return DocAppointmentsTemplate;
                }
                return base.SelectTemplate(item, container);
            }
            else
            {
                return base.SelectTemplate(item, container);
            }
        }
    }
}
