   M S B A M L   `   `   `  ����L  HWpfAppCollections, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfAppCollectionsWpfAppCollections  5   	   "    WpfAppCollections.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfAppCollections     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5
      ��%    5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��5* �6   .+�5   
   �� $��Saikou Egor 2307b��6   $��14(�6,   $��DemiBold"�6:   $
��Left=�6P   $��20,0,0,0q�6k   �� 5   
   $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��	20,25,0,0q�6   .+�5      �� -   5         ��Name$ manuComboBox��5   k   $��25��6   $	��150��6*   $
��Left=�66    �� Text$ All Manufacturers��6R   6�   �� 5      $��Showing 3 out of 3��6   $��Center=�66   5      �� 5      $��25��6   $	��150��6&   $
��Left=�62   $��20,0,0,0q�6M   $
 None��6_   .@�5      �� $
��Sort��6   �� 5      $��By Price��6   �� 5      $��By Price (Desc.)��6   �� 5      $��By Stock��6   �� 5      $��By Stock (Desc.)��6   5      �� 5       $��Add new product��6   $��25��6/   $	��150��6>   $��20,0,0,0q�6J   5!      �� 5"   
   $
��Quit��6   $��25��6    $	��100��6/   $��Right=�6;   $��0,0,20,0q�6W   �� 5$   
   -   5         ��Name$ mainList��5$      $��Center=�6%   $��Stretch=�6@   $��1��6^   5&      5'      