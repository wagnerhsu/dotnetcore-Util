﻿using Util.Ui.NgZorro.Components.Tables.Helpers;

namespace Util.Ui.NgZorro.Components.Tables.Configs;

/// <summary>
/// 表格共享配置
/// </summary>
public class TableShareConfig {
    /// <summary>
    /// 表格主体行标识
    /// </summary>
    private string _rowId;

    /// <summary>
    /// 初始化表格共享配置
    /// </summary>
    /// <param name="id">表格标识</param>
    public TableShareConfig( string id = null ) {
        Id = id.IsEmpty() ? Util.Helpers.Id.Create() : id;
        HeadColumns = new List<HeadColumnInfo>();
        Columns = new List<ColumnInfo>();
        IsAutoCreateHead = true;
        IsAutoCreateHeadRow = true;
        IsAutoCreateHeadColumn = true;
        IsAutoCreateBody = true;
        IsAutoCreateBodyRow = true;
    }

    /// <summary>
    /// 表格标识
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// 表格扩展标识
    /// </summary>
    public string TableExtendId => $"x_{Id}";

    /// <summary>
    /// 表格编辑扩展标识
    /// </summary>
    public string TableEditId => $"e_{Id}";

    /// <summary>
    /// 表格主体行标识
    /// </summary>
    public string RowId => _rowId.IsEmpty() ? $"{Id}_row" : _rowId;

    /// <summary>
    /// 表格设置组件标识
    /// </summary>
    public string TableSettingsId => $"ts_{Id}";

    /// <summary>
    /// 设置表格主体行标识
    /// </summary>
    /// <param name="rowId">行标识</param>
    public void SetRowId( string rowId ) {
        _rowId = rowId;
    }

    /// <summary>
    /// 表格总行数模板标识
    /// </summary>
    public string TotalTemplateId => $"total_{Id}";

    /// <summary>
    /// 表头列信息集合
    /// </summary>
    public List<HeadColumnInfo> HeadColumns { get; }

    /// <summary>
    /// 列信息集合
    /// </summary>
    public List<ColumnInfo> Columns { get; }

    /// <summary>
    /// 表头列数
    /// </summary>
    public int HeadColumnNumber { get; set; }

    /// <summary>
    /// 列数
    /// </summary>
    public int ColumnNumber { get; set; }

    /// <summary>
    /// 是否自动创建表头thead
    /// </summary>
    public bool IsAutoCreateHead { get; set; }

    /// <summary>
    /// 表头thead已自动创建
    /// </summary>
    public bool HeadAutoCreated { get; set; }

    /// <summary>
    /// 是否自动创建表头行tr
    /// </summary>
    public bool IsAutoCreateHeadRow { get; set; }

    /// <summary>
    /// 表头行tr已自动创建
    /// </summary>
    public bool HeadRowAutoCreated { get; set; }

    /// <summary>
    /// 是否自动创建表头单元格th
    /// </summary>
    public bool IsAutoCreateHeadColumn { get; set; }

    /// <summary>
    /// 表头单元格th已自动创建
    /// </summary>
    public bool HeadColumnAutoCreated { get; set; }

    /// <summary>
    /// 是否自动创建表格主体tbody
    /// </summary>
    public bool IsAutoCreateBody { get; set; }

    /// <summary>
    /// 表格主体tbody已自动创建
    /// </summary>
    public bool BodyAutoCreated { get; set; }

    /// <summary>
    /// 是否自动创建表格主体行tr
    /// </summary>
    public bool IsAutoCreateBodyRow { get; set; }

    /// <summary>
    /// 表格主体行tr已自动创建
    /// </summary>
    public bool BodyRowAutoCreated { get; set; }

    /// <summary>
    /// 是否启用基础扩展
    /// </summary>
    public bool IsEnableExtend { get; set; }

    /// <summary>
    /// 是否启用自动省略
    /// </summary>
    public bool IsEnableEllipsis { get; set; }

    /// <summary>
    /// 是否启用编辑模式
    /// </summary>
    public bool IsEnableEdit { get; set; }

    /// <summary>
    /// 是否启用自定义列
    /// </summary>
    public bool IsEnableCustomColumn { get; set; }

    /// <summary>
    /// 是否显示复选框
    /// </summary>
    public bool IsShowCheckbox { get; set; }

    /// <summary>
    /// 是否显示单选框
    /// </summary>
    public bool IsShowRadio { get; set; }

    /// <summary>
    /// 是否显示序号
    /// </summary>
    public bool IsShowLineNumber { get; set; }

    /// <summary>
    /// 是否固定复选框到左侧
    /// </summary>
    public bool IsCheckboxLeft { get; set; }

    /// <summary>
    /// 是否固定单选框到左侧
    /// </summary>
    public bool IsRadioLeft { get; set; }

    /// <summary>
    /// 是否固定序号到左侧
    /// </summary>
    public bool IsLineNumberLeft { get; set; }

    /// <summary>
    /// 是否树形表格
    /// </summary>
    public bool IsTreeTable { get; set; }

    /// <summary>
    /// 是否仅能选择单选框叶节点
    /// </summary>
    public bool IsCheckLeafOnly { get; set; }

    /// <summary>
    /// 行单击事件
    /// </summary>
    public string OnClickRow { get; set; }

    /// <summary>
    /// 点击是否选中行
    /// </summary>
    public bool SelectOnClickRow { get; set; }

    /// <summary>
    /// 点击是否仅选中该行
    /// </summary>
    public bool SelectOnlyOnClickRow { get; set; }

    /// <summary>
    /// 自定义列标识
    /// </summary>
    public string CustomColumnKey { get; set; }

    /// <summary>
    /// 获取列信息
    /// </summary>
    /// <param name="index">列索引</param>
    public ColumnInfo GetColumn( int index ) {
        return Columns.Find( t => t.Index == index );
    }

    /// <summary>
    /// 获取表头列信息
    /// </summary>
    /// <param name="index">列索引</param>
    public HeadColumnInfo GetHeadColumn( int index ) {
        return HeadColumns.Find( t => t.Index == index );
    }
}