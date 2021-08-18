<script src="~/lib/bootstrap-table/dist/extensions/export/bootstrap-table-export.js"></script>
    <script src="~/lib/tableexport.jquery.plugin/tableExport.js"></script>

        /**
             * 合并行
             * @@param data  原始数据（在服务端完成排序）
             * @@param fieldName 合并属性名称数组
             * @@param colspan 列数
             * @@param target 目标表格对象
             */
        function mergeCells(data, fieldName, colspan, target) {
    if (data.length == 0) {
        alert("不能传入空数据");
        return;
    }
    var numArr = [];
    var value = data[0][fieldName];
    var num = 0;
    for (var i = 0; i < data.length; i++) {
        if (value != data[i][fieldName]) {
            numArr.push(num);
            value = data[i][fieldName];
            num = 1;
            continue;
        }
        num++;
    }
    var merIndex = 0;
    for (var i = 0; i < numArr.length; i++) {
        $(target).bootstrapTable('mergeCells', { index: merIndex, field: fieldName, colspan: colspan, rowspan: numArr[i] })
        merIndex += numArr[i];
    }
}


/**
* 合并列
* @@param data  原始数据（在服务端完成排序）
* @@param fieldName 合并属性数组
* @@param target    目标表格对象
*/
function mergeColspan(data, fieldNameArr, target) {
    if (data.length == 0) {
        alert("不能传入空数据");
        return;
    }
    if (fieldNameArr.length == 0) {
        alert("请传入属性值");
        return;
    }
    var num = -1;
    var index = 0;
    for (var i = 0; i < data.length; i++) {
        num++;
        for (var v in fieldNameArr) {
            index = 1;
            if (data[i][fieldNameArr[v]] != data[i][fieldNameArr[0]]) {
                index = 0;
                break;
            }
        }
        if (index == 0) {
            continue;
        }
        $(target).bootstrapTable('mergeCells', { index: num, field: fieldNameArr[0], colspan: fieldNameArr.length, rowspan: 1 });
    }
}

/**
* 合并单元格
* @@param target 目标表格对象
* @@param data 原始数据（在服务端完成排序）
* @@param fieldName 合并参照的属性名称
* @@param fieldList 要合并的字段集合[不含fieldName]![]
* @@param colspan 合并开始列
*/
function mergeCells2(target, data, fieldName, fieldList, colspan) {
    // 声明一个map计算相同属性值在data对象出现的次数和
    var sortMap = {};
    var index = 0;
    var begini = 0;
    var endi = 0;
    // 统计fieldName长度
    getCount(target, data, 0, data.length, fieldName, index, sortMap);
    for (var prop in sortMap) {
        endi = index + sortMap[prop];
        if (sortMap[prop] > 1) {
            // console.log(fieldName + ":" + prop,sortMap[prop]);
            for (var i = 0; i < fieldList.length; i++) {
                getCount(target, data, begini, endi, fieldList[i], index, null);
            }
        }
        index = begini = endi;
    }
}

function getCount(target, data, begini, endi, fieldName, index, sortMap) {
    // console.log('fieldName:' + fieldName);
    // console.log(begini,endi);
    if (sortMap == null) {
        sortMap = {};
    }
    for (var i = begini; i < endi; i++) {
        for (var prop in data[i]) {
            if (prop == fieldName) {
                var key = data[i][prop];
                if (sortMap.hasOwnProperty(key)) {
                    sortMap[key] = sortMap[key] + 1;
                } else {
                    sortMap[key] = 1;
                }
                // console.log(fieldName + ":" + key, sortMap[key]);
                break;
            }
        }
    }
    for (var p in sortMap) {
        var count = sortMap[p] * 1;
        // console.log(">>>>>" + ":" + p , count);
        $(target).bootstrapTable('mergeCells', { index: index, field: fieldName, colspan: 1, rowspan: count });
        index += count;
    }
}
$("#mainTable").bootstrapTable({
    onLoadSuccess: function (data) {
        //mergeCells(data, "OrderId", 1, $('#mainTable'));//行合并
        mergeCells2($('#mainTable'), data, "OrderId", ["OrderDate", "MovementTypeDescription"], 1);//行合并
        //mergeColspan(data, ["FDepName3", "FDepName1", "FDepName2"], $('#table2'));//列合并
    },
})