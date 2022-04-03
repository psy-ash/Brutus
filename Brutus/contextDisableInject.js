document.addEventListener('contextmenu', function (event)
{
    let jsonObject =
    {
        Key: 'contextmenu',
        Value:
        {
            X: event.screenX,
            Y: event.screenY
        },
        objClass: JSON.stringify(document.elementFromPoint(event.clientX, event.clientY).className)
    };
    window.chrome.webview.postMessage(jsonObject);
});

document.addEventListener('mousedown', function (event)
{
    let jsonObject =
    {
        Key: 'mousedown',
        Value:
        {
            X: event.screenX,
            Y: event.screenY
        },
    };
    window.chrome.webview.postMessage(jsonObject);
});

window.document.onmousemove = function (event)
{
    let jsonObject =
    {
        Key: 'mousemove',
        Value:
        {
            X: event.clientX,
            Y: event.clientY
        },
        objClass: JSON.stringify(document.elementFromPoint(event.clientX, event.clientY).className)
    };

    if (jsonObject.objClass != null)
    {
        window.chrome.webview.postMessage(jsonObject);
    }
};