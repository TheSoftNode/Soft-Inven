function ToggleIcons(itemId, isHovering) {
    var editIcon = document.getElementById("editIcon_" + itemId);
    var deleteIcon = document.getElementById("deleteIcon_" + itemId);
    var separatorIcon = document.getElementById("separatorIcon_" + itemId);
    var manageHeader = document.getElementById("manageHeader");
    var currentTableData1 = document.getElementById("td1_" + itemId);
    var currentTableData2 = document.getElementById("td2_" + itemId);

    if (isHovering) {
        editIcon.style.display = "inline";
        deleteIcon.style.display = "inline";
        separatorIcon.style.display = "inline";
        manageHeader.style.display = "inline";
        currentTableData1.style.backgroundColor = "#COD1EC";
        currentTableData2.style.backgroundColor = "#COD1EC";
        currentTableData1.style.color = "#198AE3";
        currentTableData2.style.color = "#198AE3";
        currentTableData1.style.fontSize = "17px";
        currentTableData2.style.fontSize = "17px";
        currentTableData1.style.fontFamily = "Georgia";
        currentTableData2.style.fontFamily = "Georgia";
    } else {
        editIcon.style.display = "none";
        deleteIcon.style.display = "none";
        separatorIcon.style.display = "none";
        manageHeader.style.display = "none";
        currentTableData1.style.backgroundColor = "";
        currentTableData2.style.backgroundColor = "";
        currentTableData1.style.color = "";
        currentTableData2.style.color = "";
        currentTableData1.style.fontSize = "";
        currentTableData2.style.fontSize = "";
    }
}

function SelectedTd(itemId) {
    var td1 = document.getElementById("td1_" + itemId);
    var td1 = document.getElementById("td2_" + itemId);
}

function ToggleEditIcon(itemId, isHovering) {
    var editIcon = document.getElementById("editIcon_" + itemId);
    if (isHovering) {
        editIcon.style.fontSize = "24px";
    } else {
        editIcon.style.fontSize = "16px";
    }
}

function ToggleDeleteIcon(itemId, isHovering) {
    var deleteIcon = document.getElementById("deleteIcon_" + itemId);
    if (isHovering) {
        deleteIcon.style.fontSize = "24px";
    }
    else {
        deleteIcon.style.fontSize = "16px";
    }
}

window.updateUrl = function (newUrl) {
    window.history.replaceState(null, "", newUrl);
}