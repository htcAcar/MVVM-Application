   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StartAppStartApp  5          StartApp.CategoryView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      "localclr-namespace:StartApp  5      -   5          >�Name$  categoryView��5
   7   ���#F2F2F2 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ResourceDictionaries/Converters.xaml?�6%   %    5      .��5      � -   5         �Name$ mainGrid��5      $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��5q�6   $��0��6    5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      ]� $��0��6   $��Bottom=�6%   .+�5       �� -   5         ��Name$ 
btnRefresh��5    &   $��10q�6   $��20��6:   $��0q�6F   $
��Left=�6S   
������ ���#585858��6n   �� *RefreshCommand+��6�   Z� .��5!      �� �� 5"      $	���6   $��Segoe MDL2 Assets)�5#      $��DemiBold"�5$      $��13(�5%       �� 5&      $�Refresh��6   $��16(�5'      5(      5)      �� 5*      -   5        $ btnAdd��5*   &   $��10q�6   $��20��68   $��0q�6D   $
��Left=�6P   
������ ���#585858��6k   �� *
AddCommand+��6�   ��  �� ElementName$ categoryView����6�   Z� .��5+      �� �� 5,      $	���6   $��Segoe MDL2 Assets)�5-      $��DemiBold"�5.      $��13(�5/       �� 50      $	�Add��6   $��16(�51      52      53      �� 54      -   5        $ btnEdit��54   &   $��10q�6   $��20��68   $��0q�6D   $
��Left=�6P   
������ ���#585858��6k   �� *EditCommand+��6�   �� $ CategoryListDataGrid�� �� Path$ SelectedItem���6�   Z� {�6"  �� $ CategoryListDataGrid��$ SelectedItems.Count�   IntToBoolConverter	 �� 	Converter#	 [  
 �� ConverterParameter$
 1��.��55      �� �� 56      $	���6   $��Segoe MDL2 Assets)�57      $��DemiBold"�58      $��13(�59       �� 5:      $
�Edit��6   $��16(�5;      5<      5=      �� 5?      -   5        $ 	btnDelete��5?   &   $��10q�6   $��20��69   $��0q�6E   $
��Left=�6Q   
������ ���#585858��6m   �� *DeleteCommand+��6�   �� $ CategoryListDataGrid��$ SelectedItems���6�   Z� {�6&  �� $ CategoryListDataGrid��$ SelectedItems.Count�  GreaterThanConverter#	 [ $
 1��.��5@      �� �� 5A      $	���6   $��Segoe MDL2 Assets)�5B      $��DemiBold"�5C      $��13(�5D       �� 5E      $�Delete��6   $��16(�5F      5G      5H      5I      '  !MaterialDesignThemes.Wpf.PackIcon  5J      $��0��6'      Kind$ Search=�64   ���#2E2E2E$��Right=�6X   $��0,15,155,10q�6t     PackIconStyle#��[ 6�   �� 5K      -   5         ��Name$ 	txtSearch��5K   4   $��5,5,5,9q�6   $��0��6'   $	��150��6H   $��Right=�6T   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��6p   ���#2E2E2E$��14(�6�     TextBoxStyle#��[ 6�   ��6�   �� *
SearchText+ �� Mode$ TwoWay=� �� Delay$	 300�� �� UpdateSourceTrigger$ PropertyChanged=�&   System.Windows.Controls.DataGrid  5M      -   5          Name$ CategoryListDataGrid��5M   /   $��5q�6   $��1��6"   $��Visible=�6}      SelectionUnit$ FullRow=�6�      SelectionMode$ Extended=�6�      
IsReadOnly . ��. 4  .System.Windows.Automation.AutomationProperties   AutomationId$ PositionSummaryGrid��6  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6Q     AutoGenerateColumns .  ��6M   �� *
Categories+$ TwoWay=�.  (System.Windows.Interactivity.Interaction   Triggers 5N      /  )System.Windows.Interactivity.EventTrigger  5O         	EventName$ MouseDoubleClick��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5P      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� $ DoubleClickCommand�   CommandParameter 6\   �� $ CategoryListDataGrid��$ SelectedItem�5Q         Columns 5S      0	  *System.Windows.Controls.DataGridTextColumn	  5T      ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Category Name��6)    
  Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6@   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6M   �� *CategoryName+$ TwoWay=�	  5U      $ Description��6)   $
 Auto 6>     6K   �� *Description+$ TwoWay=�5W      5Y      �� 5Z   
   -	   5        ! ��Name$! tbFail��5Z   !   $��2��6   $��Kayıt bulunamadı!..��61   ���#B90504  TextBlockStyle#��[ 6�   y�6a   �� *FailVisibility+6�   5\      5]      