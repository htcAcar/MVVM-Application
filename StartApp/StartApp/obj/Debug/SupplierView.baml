   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StartAppStartApp  5          StartApp.SupplierView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      "localclr-namespace:StartApp  5      -   5          >�Name$  supplierView��5
   7   ���#F2F2F2 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $+ %/ResourceDictionaries/Converters.xaml?�6%   %    5      .��5      � -   5         �Name$ mainGrid��5      $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   � $��5q�6   $��0��6    5      �� 5      $
��Auto �6    �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      ]� $��0��6   $��Bottom=�6%   .+�5      �� -   5         ��Name$ 
btnRefresh��5   &   $��10q�6   $��20��6:   $��0q�6F   $
��Left=�6S   
������ ���#585858��6n   �� *RefreshCommand+��6�   Z� .��5       �� �� 5!      $	���6   $��Segoe MDL2 Assets)�5"      $��DemiBold"�5#      $��13(�5$       �� 5%      $�Refresh��6   $��16(�5&      5'      5(      �� 5)      -   5        $ btnAdd��5)   &   $��10q�6   $��20��68   $��0q�6D   $
��Left=�6P   
������ ���#585858��6k   �� *
AddCommand+��6�   ��  �� ElementName$ supplierView����6�   Z� .��5*      �� �� 5+      $	���6   $��Segoe MDL2 Assets)�5,      $��DemiBold"�5-      $��13(�5.       �� 5/      $	�Add��6   $��16(�50      51      52      �� 53      -   5        $ btnEdit��53   &   $��10q�6   $��20��68   $��0q�6D   $
��Left=�6P   
������ ���#585858��6k   �� *EditCommand+��6�   �� $ SupplierListDataGrid�� �� Path$ SelectedItem���6�   Z� {�6"  �� $ SupplierListDataGrid��$ SelectedItems.Count�   IntToBoolConverter	 �� 	Converter#	 [  
 �� ConverterParameter$
 1��.��54      �� �� 55      $	���6   $��Segoe MDL2 Assets)�56      $��DemiBold"�57      $��13(�58       �� 59      $
�Edit��6   $��16(�5:      5;      5<      �� 5>      -   5        $ 	btnDelete��5>   &   $��10q�6   $��20��69   $��0q�6E   $
��Left=�6Q   
������ ���#585858��6m   �� *DeleteCommand+��6�   �� $ SupplierListDataGrid��$ SelectedItems���6�   Z� {�6&  �� $ SupplierListDataGrid��$ SelectedItems.Count�  GreaterThanConverter#	 [ $
 1��.��5?      �� �� 5@      $	���6   $��Segoe MDL2 Assets)�5A      $��DemiBold"�5B      $��13(�5C       �� 5D      $�Delete��6   $��16(�5E      5F      5G      5H      '  !MaterialDesignThemes.Wpf.PackIcon  5I      $��0��6'      Kind$ Search=�64   ���#2E2E2E$��Right=�6X   $��0,15,155,10q�6t     PackIconStyle#��[ 6�   �� 5J      -   5         ��Name$ 	txtSearch��5J   4   $��5,5,5,9q�6   $��0��6'   $	��150��6H   $��Right=�6T   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��6p   ���#2E2E2E$��14(�6�     TextBoxStyle#��[ 6�   ��6�   �� *
SearchText+ �� Mode$ TwoWay=� �� Delay$	 300�� �� UpdateSourceTrigger$ PropertyChanged=�&   System.Windows.Controls.DataGrid  5M      -   5          Name$ SupplierListDataGrid��5M   /   $��5q�6   $��1��6"   $��Visible=�6}      SelectionUnit$ FullRow=�6�      SelectionMode$ Extended=�6�      
IsReadOnly . 4  .System.Windows.Automation.AutomationProperties   AutomationId$ PositionSummaryGrid��6�   ��. $ �� IsSynchronizedWithCurrentItem$
 TrueY�6P     AutoGenerateColumns . ��6M   �� *	Suppliers+$ TwoWay=�.  (System.Windows.Interactivity.Interaction   Triggers 5N      /  )System.Windows.Interactivity.EventTrigger  5O         	EventName$ MouseDoubleClick��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5P      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� $ DoubleClickCommand�   CommandParameter 6\   �� $ SupplierListDataGrid��$ SelectedItem�5Q         Columns 5S      0	  *System.Windows.Controls.DataGridTextColumn	  5T      ,
  &System.Windows.Controls.DataGridColumn 
  Header$ Company Name��6)    
  Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6?   1  +System.Windows.Controls.DataGridBoundColumn    Binding  6L   �� *CompanyName+$ TwoWay=�	  5U      $ Contact Name��6)   $
 Auto 6?     6L   �� *ContactName+$ TwoWay=�	  5V      $ Contact Title��6)   $
 Auto 6@     6M   �� *ContactTitle+$ TwoWay=�	  5W      $ Address��6)   $
 Auto 6:     6G   �� *	Address+$ TwoWay=�	  5X      $
 City��6)   $
 Auto 67     6D   �� *City+$ TwoWay=�	  5Y      $ Region��6)   $
 Auto 69     6F   �� *Region+$ TwoWay=�	  5Z      $ Postal Code��6)   $
 Auto 6>     6K   �� *
PostalCode+$ TwoWay=�	  5[      $ Country��6)   $
 Auto 6:     6G   �� *	Country+$ TwoWay=�	  5\      $ Phone��6)   $
 Auto 68     6E   �� *Phone+$ TwoWay=�	  5]      $	 Fax��6)   $
 Auto 66     6C   �� *Fax+$ TwoWay=�	  5^      $ 	Home Page��6)   $
 Auto 6<     6I   �� *
HomePage+$ TwoWay=�5`      5a      �� 5b   
   -	   5        ! ��Name$! tbFail��5b   !   $��2��6   $��Kayıt bulunamadı!..��61   ���#B90504  TextBlockStyle#��[ 6�   y�6a   �� *FailVisibility+6�   5d      5e      