   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StartAppStartApp  5   	       StartApp.ProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   "localclr-namespace:StartApp  5   	   -   5          �Name$  productWindow��5   ;    � 
ResizeMode$ CanResizeWithGrip=�5
   	    � Icon$ /Images/list.png��5   	    � Title$ Products��5   	   $
��1040��6   $	��650��6+   ���#F2F2F2 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Grey.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6%   �� 5      $+ %/ResourceDictionaries/Converters.xaml?�6%   %    5      .��5      � -   5        $��mainGrid��5      $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   � $��5q�6   $��Stretch=�6   $��0��68    5      �� 5      $
��auto �6    �� 5       $
��auto �6    .+�5"      ]� $��0��6   .+�5#      �� -   5         ��Name$ btnBack��5#   (   $
��9,20q�6   $��20��6;   $��0q�6G   $
��Left=�6S   
������ ���#585858��6o   �� *BackCommand+��6�   �� 	 �� ElementName$	 productWindow����5$   *   Z� .��5%      �� �� 5&      $	���6   $��Segoe MDL2 Assets)�5'      $��DemiBold"�5(      $��13(�5)       �� 5*      $
�Back��6   $��16(�5+      5,      5-      �� 5.      $��10q�6   $��Products��6)   $��Center=�69   $
��Bold"�6V   $��24(�6h   $��Segoe UI)�6v   ���#7979856�   5/      ]� 50      $��1��6   $��Bottom=�6'   .+�51      �� -   5        $ 
btnRefresh��51   &   $��10q�6   $��20��6:   $��0q�6F   $
��Left=�6S   
������ ���#585858��6o   �� *RefreshCommand+��6�   �� $	 productWindow����52   *   Z� .��53      �� �� 54      $	���6   $��Segoe MDL2 Assets)�55      $��DemiBold"�56      $��13(�57       �� 58      $�Refresh��6   $��16(�59      5:      5;      �� 5<      -   5        $ btnAdd��5<   &   $��10q�6   $��20��68   $��0q�6D   $
��Left=�6P   
������ ���#585858��6l   �� *
AddCommand+��6�   �� $	 productWindow����5=   *   Z� .��5>      �� �� 5?      $	���6   $��Segoe MDL2 Assets)�5@      $��DemiBold"�5A      $��13(�5B       �� 5C      $	�Add��6   $��16(�5D      5E      5F      �� 5G      -   5        $ btnEdit��5G   &   $��10q�6   $��20��68   $��0q�6D   $
��Left=�6P   
������ ���#585858��6k   �� *EditCommand+��6�   �� $	 ProductListDataGrid��
 �� Path$
 SelectedItem���6�   Z� {�6   �� $	 ProductListDataGrid��$
 SelectedItems.Count�   IntToBoolConverter �� 	Converter# [   �� ConverterParameter$ 1��.��5H      �� �� 5I      $	���6   $��Segoe MDL2 Assets)�5J      $��DemiBold"�5K      $��13(�5L       �� 5M      $
�Edit��6   $��16(�5N      5O      5P      �� 5R      -   5        $ 	btnDelete��5R   &   $��10q�6   $��20��69   $��0q�6E   $
��Left=�6Q   
������ ���#585858��6m   �� *DeleteCommand+��6�   �� $	 ProductListDataGrid��$
 SelectedItems���6�   Z� {�6%  �� $	 ProductListDataGrid��$
 SelectedItems.Count�  GreaterThanConverter# [ $ 1��.��5S      �� �� 5T      $	���6   $��Segoe MDL2 Assets)�5U      $��DemiBold"�5V      $��13(�5W       �� 5X      $�Delete��6   $��16(�5Y      5Z      5[      5]      '  !MaterialDesignThemes.Wpf.PackIcon  5_      $��1��6'      Kind$ Search=�64   ���#2E2E2E$��Right=�6X   $��0,15,155,10q�6t     PackIconStyle#��[ 6�   �� 5`      -   5         ��Name$ 	txtSearch��5`   4   $��5,5,5,9q�6   $��1��6'   $	��150��6H   $��Right=�6T   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��6p   ���#2E2E2E$��14(�6�     TextBoxStyle#��[ 6�   ��6�   �� *
SearchText+ �� Mode$ TwoWay=� �� Delay$	 300�� �� UpdateSourceTrigger$ PropertyChanged=�5a      � 5b   
   $��5q�6   $��Stretch=�6   $��1��69    5c      �� 5d      $��* �6    �� 5e      $
��Auto �6    .+�5g      &   System.Windows.Controls.DataGrid  -	   5          Name$ ProductListDataGrid��5g   /   $��5q�6   $��0��6"   $��Visible=�6z      SelectionUnit$ FullRow=�6�      SelectionMode$ Extended=�6�      
IsReadOnly . ��. 4  .System.Windows.Automation.AutomationProperties   AutomationId$ PositionSummaryGrid��6?  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6x     AutoGenerateColumns .  ��6L   �� *
Products+$ TwoWay=� �� SelectedItem 6�   �� *SelectedProduct+.  (System.Windows.Interactivity.Interaction   Triggers 5h      /  )System.Windows.Interactivity.EventTrigger  5i         	EventName$ MouseDoubleClick��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5j      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� $
 DoubleClickCommand�   CommandParameter 6\   �� $	 ProductListDataGrid��$
 SelectedItem�5k          Columns  5m      0	  *System.Windows.Controls.DataGridTextColumn	  5n      ,
  &System.Windows.Controls.DataGridColumn! 
  Header$! Product Name��6)   " 
  Width5  /System.Windows.Controls.DataGridLengthConverter$
" Auto 6?   1  +System.Windows.Controls.DataGridBoundColumn#   Binding# 6L   �� *ProductName+$ TwoWay=�	  5o      $! Company Name��6)   $
" Auto 6?   # 6L   �� *CompanyName+$ TwoWay=�	  5p      $! Category��6)   $
" Auto 6;   # 6H   �� *
Category+$ TwoWay=�	  5q      $! Quantity Per Unit��6)   $
" Auto 6D   # 6Q   �� *QuantityPerUnit+$ TwoWay=�	  5r      $! 
Unit Price��6)   $
" Auto 6=   # 6J   �� *	UnitPrice+$ TwoWay=�5t      �� 5v      -
   5        $ ��Name$$ tbFail��5v   %   $��1��6   $��Ürün bulunamadı!..��65   ���#B90504  TextBlockStyle#��[ 6�   y�6d   �� *FailVisibility+6�   5w      5x      5y      