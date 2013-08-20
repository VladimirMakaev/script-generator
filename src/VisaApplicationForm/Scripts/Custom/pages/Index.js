var previousVisas = 0;
var prevVisasTemplate;

function Init(scope) {
    $(function () {
        prevVisasTemplate =  $(scope.RangeTemplateSelector).clone();
        $(scope.DatePickerSelector).datepicker();
        $(scope.AddRangeLinkSelector).click(function () {
            previousVisas++;
            var template = prevVisasTemplate.clone();
            var fromLabel = template.find('label:first');
            var toLabel = template.find('label:last');
            UpdateLabel(fromLabel);
            UpdateLabel(toLabel);
            var fromInput = template.find('input:first');
            var toInput = template.find('input:last');
            UpdateInput(fromInput);
            UpdateInput(toInput);
            $(scope.PreviousVisasContainerSelector).append(template);
        });
    });
}


function UpdateLabel(element) {
    element.attr("for", element.attr("for").replace("0", previousVisas));
}

function UpdateInput(element) {
    element.attr("name", element.attr("name").replace("0", previousVisas));
    element.attr("id", element.attr("id").replace("0", previousVisas));
    element.datepicker();
}
