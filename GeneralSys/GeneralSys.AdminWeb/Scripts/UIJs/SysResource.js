//grid列表模块
function MainGrid() {
    this.maingrid = $("#maingrid").datagrid({
        showToolbar: false,
        filterThead: false,
        target: $(this),
        columns: [
                {
                    name: 'Id',
                    label: '编号',
                    align: 'center',
                    width: 70
                },
                {
                    name: 'Name',
                    label: '资源名称',
                    align: 'center'
                },
                {
                    name: 'Url',
                    label: '资源地址',
                    align: 'center',
                    type: 'date'
                },
                {
                    name: 'Icon',
                    label: '资源图标',
                    align: 'center',
                    type: 'date'
                }
        ],
        dataUrl: '/SysResource/GetAllResource',
        fullGrid: true,
        showLinenumber: true,
        showCheckboxcol: true,
        paging: true,
        filterMult: false,
        showTfoot: false
    });
};
MainGrid.prototype = new Grid();
var list = new MainGrid();