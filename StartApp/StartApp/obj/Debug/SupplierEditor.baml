   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:StartApp.ValidationRulesStartApp.ValidationRules  5   	   #clr-namespace:StartAppStartApp  5   	       StartApp.SupplierEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   BvalidationRules&clr-namespace:StartApp.ValidationRules     5   	   (localclr-namespace:StartApp     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          �Name$  supplierEditorWindow��5
   y   $	��600��6%   $	��975��62   ���#F2F2F2 � 
ResizeMode$ NoResize=�6�    � Title 6	   �� *	PageTitle+.��5      � -   5        $��SupplierEditorMainGrid��5      $��20q�6   .+�5   
   �� -   5         ��Name$ txtTitle��5   C   $��5q�6   $��0��6   $	��Top=�6U   $��24(�6n   ���#797985   TextBlockStyle#��[  6�   ��6,   �� *Title+6�   � 5   
   $��10q�6   $��Center=�6   $
��Left=�66    � RowDefinitions 5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      ]� .+�5      �� $
��Left=�6   $	��450��63   .+�5      �� -   5         ��Name$ txtCompanyName��5   8   $��10q�6   $��0��6+   $	��400��6P   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Company Name��6\     TextBoxStyle#��[ 6�   .��6�   ��5      �� 5       �� Path$ CompanyName�6&    �� UpdateSourceTrigger$ PropertyChanged=�69   	 �� Mode$	 TwoWay=�6_   
 �� ValidationRules
 5   "   5   /StartApp.ValidationRules.RequiredValidationRule  5   &   5!      .��5"   (   5#      �� 5$      -   5        $ txtContactName��5$   8   $��10q�6   $��1��6+   $	��400��6P   $ Contact Name��6\   #��[ 6�   .��6�   ��5%      �� 5&      $ ContactName�6&   $ PropertyChanged=�69   $	 TwoWay=�6_   
 5'   "     5(   &   5*      .��5+   (   5,      �� 5-      -   5        $ txtContactTitle��5-   8   $��10q�6   $��2��6+   $	��400��6Q   $ Contact Title��6]   #��[ 6�   .��6�   ��5.      �� 5/      $ ContactTitle�6&   $ PropertyChanged=�6:   $	 TwoWay=�6`   
 50   "     51   &   53      .��54   (   55      �� 56      -   5        $ 
txtAddress��56   8   $��10q�6   $��3��6+   $	��400��6L   $ Address��6X   #��[ 6�   .��6�   ��57      �� 58      $ Address�6&   $ PropertyChanged=�65   $	 TwoWay=�6[   
 59   "     5:   &   5<      .��5=   (   5>      �� 5?      -   5        $ txtCity��5?   8   $��10q�6   $��4��6+   $	��400��6I   $
 City��6U   #��[ 6{   .��6�   ��5@      �� 5A      $
 City�6&   $ PropertyChanged=�62   $	 TwoWay=�6X   
 5B   "     5C   &   5E      .��5F   (   5G      �� 5H      -	   5        $ 	txtRegion��5H   8   $��10q�6   $��5��6+   $	��400��6K   $ Region��6W   #��[ 6   .��6�   ��5I      �� 5J      $ Region�6&   $ PropertyChanged=�64   $	 TwoWay=�6Z   
 5K   "     5L   &   5N      .��5O   (   5P      5Q      �� 5R      $
��Left=�6   $	��450��63   .+�5S      �� -
   5        $ txtPostalCode��5S   7   $��10q�6   $��0��6*   $	��400��6N   $ Postal Code��6Z   #��[ 6�   .��6�   ��5T      �� 5U      $ 
PostalCode�6&   $ PropertyChanged=�68   $	 TwoWay=�6^   
 5V   "     5W   &   5Y      .��5Z   (   5[      �� 5\      -   5        $ 
txtCountry��5\   8   $��10q�6   $��1��6+   $	��400��6L   $ Country��6X   #��[ 6�   .��6�   ��5]      �� 5^      $ Country�6&   $ PropertyChanged=�65   $	 TwoWay=�6[   
 5_   "     5`   &   5b      .��5c   (   5d      �� 5e      -   5        $ txtPhone��5e   8   $��10q�6   $��2��6+   $	��400��6J   $ Phone��6V   #��[ 6}   .��6�   ��5f      �� 5g      $ Phone�6&   $ PropertyChanged=�63   $	 TwoWay=�6Y   
 5h   "     5i   &   5k      .��5l   (   5m      �� 5n      -   5        $ txtFax��5n   7   $��10q�6   $��3��6*   $	��400��6G   $	 Fax��6S   #��[ 6x   .��6�   ��5o      �� 5p      $	 Fax�6&   $ PropertyChanged=�61   $	 TwoWay=�6W   
 5q   "     5r   &   5t      .��5u   (   5v      �� 5w      -   5        $ txtHomePage��5w   7   $��10q�6   $��4��6*   $	��400��6L   $ 	Home Page��6X   #��[ 6�   .��6�   ��5x      �� 5y      $ HomePage�6&   $ PropertyChanged=�66   $	 TwoWay=�6\   
 5z   "     5{   &   5}      .��5~   (   5      5�      5�      5�      �� 5�      $��5,5,52,5q�6    �� Orientation$ 
Horizontal=�6)   $��2��6B   $��Right=�6V   $��Bottom=�6r   .+�5�      �� -   5         ��Name$ btnSave��5�       $��5q�6   $
��Save��61     ButtonStyle#��[ 6@   ��6e   �� *SaveCommand+��6�   ��  �� ElementName$ supplierEditorWindow���� 5�      -   5        $ 	btnCancel��5�       $��5q�6   $��Cancel��63   #��[ 6D   ��6i   �� *CancelCommand+��6�   �� $ supplierEditorWindow��5�      5�      5�      