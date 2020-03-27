# Umbraco Forms demo

A demo of Umbraco Forms using Umbraco 7.7.6 and Umbraco Forms 6.0.8.

You can login to this demo as demo@example.org / demodemodemo.

## What is it?

- Lets developers or editors build forms with little or no code
- Paid (but inexpensive) plugin for Umbraco
- Less mature than Umbraco itself. Be aware older versions are a bit buggy, particularly around conditions and especially for radio buttons

## Show 'Everything' form

- included field types
- help text / default values / placeholder text
- validation - required and regex
- groups / columns / themes
- conditions (by group, by field - supports multiple conditions to show a field)
- multi-page forms
- pre-value source - from Umbraco content but could also come from database / text file / data type
- submit - goes to thank you page
- workflow - some built-in, eg email / Slack, or code anything in C#
- entries viewer - show approval / uploaded image / filter entries / CSV download

## Create a form

- Create a new form
- Add fields:
  - section one
    - title (dropdown, inc other)
    - other title (with condition)
  - section two
    - name (required)
- Show workflow options
- Show document type, add a form picker, show that there is a template
- Create a page to host it
- Fill it in

## Deeper dive

- Where's the data?
  - Forms in [App_Data/UmbracoForms/Data/forms](UmbracoFormsDemo/App_Data/UmbracoForms/Data/forms)
  - If you can't find them it could be a virtual directory
  - Typically not source controlled (unlike here) as managed by editors
  - Form data in the database, though you can turn that off by editing JSON
- Permissions
  - to see the Forms section
  - Manage Forms controls form design and viewing entries
  - Aside: data sources are to send data direct to a web service or SQL, but you could do that with a workflow
  - Per-form permissions
  - Permissions granted by default
- Custom field type - Gender
  - [Forms/Gender.cs](UmbracoFormsDemo/Forms/Gender.cs)
  - View at [Views/Partials/Forms/Themes/default/Fieldtypes/FieldType.Gender.cshtml](UmbracoFormsDemo/Views/Partials/Forms/Themes/default/Fieldtypes/FieldType.Gender.cshtml)
  - FieldType at [App_Plugins/UmbracoForms/Backoffice/Common/FieldTypes/Gender.html](UmbracoFormsDemo/App_Plugins/UmbracoForms/Backoffice/Common/FieldTypes/Gender.html)
  - RenderType at [App_Plugins/UmbracoForms/Backoffice/Common/RenderTypes/gender.html](UmbracoFormsDemo/App_Plugins/UmbracoForms/Backoffice/Common/RenderTypes/gender.html)
- Custom workflow [Forms/RetentionAfterSetDateWorkflow.cs](UmbracoFormsDemo/Forms/RetentionAfterSetDateWorkflow.cs) demonstrating updating a field with the alias `deleteAfter` based on custom settings
- Custom setting type for rich HTML on the Gender field type
  - Setting added in `Gender.cs`
  - [App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/RichTextEditor.html](UmbracoFormsDemo/App_Plugins/UmbracoForms/Backoffice/Common/SettingTypes/RichTextEditor.html)
  - Custom controller for editing in [App_Plugins/UmbracoFormsContrib](UmbracoFormsDemo/App_Plugins/UmbracoFormsContrib) (only needed because TinyMCE requires JS)
  - View at [Views/Partials/Forms/Themes/default/Fieldtypes/FieldType.Gender.cshtml](UmbracoFormsDemo/Views/Partials/Forms/Themes/default/Fieldtypes/FieldType.Gender.cshtml) updated to use/display the setting
  - Also show built-in Content Picker setting type

## Security issues

- Permissions granted by default (already mentioned)
- Uploads rely on security by obscurity
- No retention schedule
- Default email sends out all form fields including private data. May be mitigated by sensitive data fields from Umbraco 7.9/Umbraco Forms 7.0?
