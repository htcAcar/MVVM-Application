   M S B A M L   `   `   `  ����C  ?StartApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:StartAppStartApp  5   	       StartApp.DetailWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   "localclr-namespace:StartApp  5   	   -   5          �Name$  detailWindow��5
   >    � 
ResizeMode$ CanResizeWithGrip=�5	   	    � Title$ DetailWindow��5
   	   $	��960��6   $	��600��6.   ���#F2F2F2 � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $e _pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Light.xaml?�6%   �� 5      $h bpack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Defaults.xaml?�6%   �� 5      $t npack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Primary/MaterialDesignColor.Grey.xaml?�6%   �� 5      $s mpack://application:,,,/MaterialDesignColors;component/Themes/Recommended/Accent/MaterialDesignColor.Lime.xaml?�6%   �� 5      $+ %/ResourceDictionaries/Converters.xaml?�6%   %    5      .��5      � -   5         �Name$ mainGrid��5      $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   ]� $��0��6   .+�5      �� -   5         ��Name$ btnBack��5   $   $
��9,20q�6   $��20��67   $��0q�6C   $
��Left=�6O   
������ ���#585858��6k   �� *BackCommand+��6�   �� 	 �� ElementName$	 detailWindow����5   *   Z� .��5      �� �� 5      $	���6   $��Segoe MDL2 Assets)�5       $��DemiBold"�5!      $��13(�5"       �� 5#      $
�Back��6   $��16(�5$      5%      5&      �� 5'      -   5        
 ��Name$
 txtTitle��5'   ?   $��5q�6   $��0��6#   $��Details��60   $	��Top=�6Q   $��24(�6j   ���#797985   TextBlockStyle#��[  6�   5(      �� 5)   
   $
��Auto��6   $��1��6#   $��0q�60    �� SelectedIndex 6D   �� *SelectedTab+ �� SelectedItem 6j   �� *SelectedObject+ 5*       �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName��%4  '��       �� 5+      " ��6   .�5,      ��  � �� 5-      �� 5.      " ��6.   .R�5/   "   �� $��Border��6)   $��1,1,1,0q�67   
�������$ 4,4,0,0��6i   $��-1,0,3,0q�6�   ._�50   &   �� $��Center=�67   $��Center=�6R   $��Header��51   )   $
��10,2q�52   )   53   #    54   "   P� 55   &    �@��
IsSelected . . �56   *   �� $ Border��61    � ��
 �����6[   57   '   P� 58   &    �@��
IsSelected .  . �59   *   �� $ Border��61    � �� �#F2F2F26[   5:   '   5<      5>      5?      5@      ��5A      �� 5B       �� Color$ white��6"   .@�5E      �� $��
Categories��6   ���#797985.��5F      �� ��6"   �� *CategoryViewModel+ �� IsAsync . ��5G      �� 5H      " ��6     �� Triggers 5I      P� 5J   "    � {� .  . �5K   &   ��  �@J�BitmapEffect 5L   *   �� 5M   .    �� 
KernelType$	 Box=�6?    �� Radius$ 3Q�6P   5O   '   5P   #   5R      5T      5U      �� 5W      $��	Suppliers��6   ���#797985.��5X      �� ��6"   �� *SupplierViewModel+ . ��5Y      �� 5Z      " ��6     5[      P� 5\   "    � {� .  . �5]   &   ��  �@J�BitmapEffect 5^   *   �� 5_   .   $	 Box=�6?   $ 3Q�6P   5a   '   5b   #   5d      5f      5g      5h      5i      5j      