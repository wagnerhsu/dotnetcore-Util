﻿using Util.Ui.NgZorro.Components.Tables.Helpers;

namespace Util.Ui.NgZorro.Components.Tables.Configs;

/// <summary>
/// 表头列共享配置
/// </summary>
public class TableHeadColumnShareConfig {
    /// <summary>
    /// 表格共享配置
    /// </summary>
    private readonly TableShareConfig _tableShareConfig;

    /// <summary>
    /// 初始化表头列共享配置
    /// </summary>
    /// <param name="tableShareConfig">表格共享配置</param>
    public TableHeadColumnShareConfig( TableShareConfig tableShareConfig ) {
        _tableShareConfig = tableShareConfig;
        Index = _tableShareConfig.HeadColumnNumber;
        _tableShareConfig.HeadColumnNumber++;
    }

    /// <summary>
    /// 是否树形表格
    /// </summary>
    public bool IsTreeTable => _tableShareConfig.IsTreeTable;

    /// <summary>
    /// 表格扩展标识
    /// </summary>
    public string TableExtendId => _tableShareConfig.TableExtendId;

    /// <summary>
    /// 表格编辑扩展标识
    /// </summary>
    public string TableEditId => _tableShareConfig.TableEditId;

    /// <summary>
    /// 是否启用自定义列
    /// </summary>
    public bool IsEnableCustomColumn => _tableShareConfig.IsEnableCustomColumn;

    /// <summary>
    /// 是否显示复选框
    /// </summary>
    public bool IsShowCheckbox => _tableShareConfig.IsShowCheckbox;

    /// <summary>
    /// 是否显示单选框
    /// </summary>
    public bool IsShowRadio => _tableShareConfig.IsShowRadio;

    /// <summary>
    /// 是否显示序号
    /// </summary>
    public bool IsShowLineNumber => _tableShareConfig.IsShowLineNumber;

    /// <summary>
    /// 是否固定复选框到左侧
    /// </summary>
    public bool IsCheckboxLeft => _tableShareConfig.IsCheckboxLeft;

    /// <summary>
    /// 是否固定单选框到左侧
    /// </summary>
    public bool IsRadioLeft => _tableShareConfig.IsRadioLeft;

    /// <summary>
    /// 是否固定序号到左侧
    /// </summary>
    public bool IsLineNumberLeft => _tableShareConfig.IsLineNumberLeft;

    /// <summary>
    /// 是否自动创建表头单元格th
    /// </summary>
    public bool IsAutoCreateHeadColumn {
        get => _tableShareConfig.IsAutoCreateHeadColumn;
        set => _tableShareConfig.IsAutoCreateHeadColumn = value;
    }

    /// <summary>
    /// 是否第一列
    /// </summary>
    public bool IsFirst { get; set; }

    /// <summary>
    /// 索引
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// 自定义列标识
    /// </summary>
    public string CellControl {
        get {
            var column = _tableShareConfig.GetColumn( Index );
            if (column == null)
                return null;
            return column.GetCellControl();
        }
    }

    /// <summary>
    /// 设置第一列
    /// </summary>
    public void SetIsFirst() {
        if ( Index == 0 )
            IsFirst = true;
    }

    /// <summary>
    /// 添加列
    /// </summary>
    /// <param name="column">列信息</param>
    public void AddColumn( HeadColumnInfo column ) {
        if ( column == null )
            return;
        column.Index = Index;
        _tableShareConfig.HeadColumns.Add( column );
    }
}