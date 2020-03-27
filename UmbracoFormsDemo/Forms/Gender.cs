using System;
using Umbraco.Forms.Core;
using Umbraco.Forms.Core.Attributes;

namespace UmbracoFormsDemo.Forms
{
    public class Gender : FieldType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Gender"/> class.
        /// </summary>
        public Gender()
        {
            Id = new Guid("f384b6df-1344-4416-a4af-562c97a23844");
            Name = "Gender";
            Description = "Only ask if you'll use it. Call it 'Gender', not 'Sex' (unless it's medical).";
            DataType = FieldDataType.String;
            FieldTypeViewName = "FieldType.Gender.cshtml";
            Icon = "icon-male-and-female";
            HideLabel = false;
            SupportsPrevalues = false;
            SupportsRegex = false;
            SortOrder = 100;
            RenderView = "gender"; // /App_Plugins/UmbracoForms/BackOffice/Common/RenderTypes/gender.html
        }

        [Setting("Example custom setting type", view = "RichTextEditor")]
        public string ExampleHtmlSetting { get; set; }

        [Setting("Example content picker setting", view = "pickers.content")]
        public string ContentPicker { get; set; }
    }
}