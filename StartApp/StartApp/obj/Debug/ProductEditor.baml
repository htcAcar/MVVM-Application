   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StartApp.ValidationRulesStartApp.ValidationRules  5   	   #clr-namespace:StartAppStartApp  5   	       StartApp.ProductEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   BvalidationRules&clr-namespace:StartApp.ValidationRules     5   	   (localclr-namespace:StartApp     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          �Name$  productEditorWindow��5   N    � Icon$ /Images/edit.png��5
   	    � Title$ Product Editor��5   	   $	��500��6    $	��600��6-   ���#F2F2F2 � 
ResizeMode$ NoResize=�6�   .��5      � -   5        $��ProductEditorMainGrid��5      $��20q�6   .+�5   
   �� -   5         ��Name$ txtTitle��5   C   $��5q�6   $��0��6   $	��Top=�6U   $��24(�6m   ���#797985   TextBlockStyle#��[  6�   ��6,   �� *Title+6�   � 5   
   $��10q�6   $��Center=�6   $
��Left=�66    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6     � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $
��auto �6#   .+�5!      �� -   5         ��Name$ txtProductName��5!   @   $��10q�6   $��1��6#   $��0��60   $	��475��6X   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Product Name��6d     TextBoxStyle#��[ 6�   .��6�   ��5"      �� 5#      	 �� Path$	 ProductName�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�61    �� ValidationRules 5$      5   /StartApp.ValidationRules.RequiredValidationRule  5%      ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated .    ValidationStep$ UpdatedValue=�6e   5'      .��5(       5)      �� 5+      -   5         ��Name$ cbCompanyName��5+   %   $��10q�6   $��0��6<   $��2��6L   $
��Bold"�6Y   ���#797985$ Company Name��6�    & "MaterialDesignFloatingHintComboBox#��[ 6�    �� SelectedValuePath$ 
SupplierID��6Y   �� DisplayMemberPath$ CompanyName��6x   �� Text 6�   �� *CompanyName+��6  �� *SupplierList+ �� SelectedItem 6,  �� *SelectedCompanyName+6x  �� 5-      -   5        $ 
cbCategory��5-   %   $��10q�6   $��0��69   $��3��6I   $
��Bold"�6V   ���#797985$ Category��6�   #��[ 6�   $ 
CategoryID��6M  $ CategoryName��6l   6}   �� *
Category+��6�   �� *CategoryList+ 6#  �� *SelectedCategory+6l  �� 5/      -   5        $ txtQuantityPerUnit��5/   @   $��10q�6   $��4��6#   $��0��60   $	��475��6\   $ Quantity Per Unit��6i   #��[ 6�   .��6�   ��50      �� 51      $	 QuantityPerUnit�6   $
 PropertyChanged=�65    52        53      55      .��56       57      �� 59      -   5        $ txtUnitPrice��59   @   $��10q�6   $��5��6#   $��0��60   $	��475��6V   $ 
Unit Price��6c   #��[ 6�   .��6�   ��5:      �� 5;      $	 	UnitPrice�6   $
 PropertyChanged=�6/    5<        5=      5?      .��5@       5A      5C      �� 5E   
   $��5,5,52,5q�6    �� Orientation$ 
Horizontal=�6'   $��2��6@   $��Right=�6T   $��Bottom=�6p   .+�5F      �� -	   5         ��Name$ btnSave��5F   !   $��5q�6   $
��Save��62     ButtonStyle#��[ 6A   ��6f   �� *SaveCommand+��6�   ��  �� ElementName$ productEditorWindow���� 5G      -
   5        $ 	btnCancel��5G   !   $��5q�6   $��Cancel��64   #��[ 6F   ��6k   �� *CancelCommand+��6�   �� $ productEditorWindow��5H      5I      5J      