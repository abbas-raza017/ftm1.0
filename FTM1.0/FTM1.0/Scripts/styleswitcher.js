if ($.cookie("color")) {
    $("#colorSwitchLink").attr("href", "/Content/css/" + $.cookie("color"));
}

if ($.cookie("width")) {
    $("link[href|='Content/css/width']").attr("href", "/Content/css/" + $.cookie("width"));
}

$(document).ready(function () {
    $("#color-switcher-content .color").click(function () {
        $("#colorSwitchLink").attr("href", "/Content/css/" + $(this).attr('rel'));
        $.cookie("color", $(this).attr('rel'), { expires: 7, path: '/' });
        return false;
    });

    $("#color-switcher-content .option").click(function () {
        $("link[href|='Content/css/width']").attr("href", "/Content/css/" + $(this).attr('rel'));
        console.log('test');
        $.cookie("width", $(this).attr('rel'), { expires: 7, path: '/' });
        return false;
    });
});