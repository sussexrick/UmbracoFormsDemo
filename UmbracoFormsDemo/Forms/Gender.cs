using System;
using Umbraco.Forms.Core;

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
    }
}