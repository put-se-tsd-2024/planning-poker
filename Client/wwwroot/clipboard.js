window.copyToClipboard = function(text) {
    const textarea = document.createElement('textarea');
    textarea.value = text;
    textarea.style.position = 'fixed';
    document.body.appendChild(textarea);

    textarea.select();
    document.execCommand('copy');

    document.body.removeChild(textarea);
    alert("Link has been copied to clipboard");
}

window.BlazorDownloadFile = {
    saveAsFile: function (fileName, byteBase64) {
        const blob = base64toBlob(byteBase64);
        const url = window.URL.createObjectURL(blob);
        const a = document.createElement("a");
        document.body.appendChild(a);
        a.style = "display: none";
        a.href = url;
        a.download = fileName;
        a.click();
        window.URL.revokeObjectURL(url);
    }
};

function base64toBlob(base64) {
    const byteString = atob(base64);
    const buffer = new ArrayBuffer(byteString.length);
    const array = new Uint8Array(buffer);

    for (let i = 0; i < byteString.length; i++) {
        array[i] = byteString.charCodeAt(i);
    }

    return new Blob([buffer], { type: "application/octet-stream" });
}
