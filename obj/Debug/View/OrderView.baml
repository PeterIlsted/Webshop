   M S B A M L   `   `   `  ����B  >Webshop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Webshop.ViewWebshop.View  5   	       Webshop.View.OrderView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Webshop.View     5   	     � Title$  	OrderView��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��4* �6   �� 5      $��1* �6   .+�5   
   � $��0��6   .+�5      � $��0��6   5      5      � 5   
   $��1��6   
������.+�5      �  � ColumnDefinitions 5      �� 5      $��6* �6'   �� 5      $��2* �6'   .+�5      � $��0��6   .+�5      &   System.Windows.Controls.DataGrid     CanUserAddRows .     CanUserDeleteRows .     AutoGenerateColumns .  ��5      �� *Basket+ �� SelectedItem 5       �� *SelectedItem+   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��61   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6?   �� *Name+  5#      $ Quantity��61   	 6C   �� *Count+  5$      $ Price��61   	 6@   �� *
TotalPrice+5'      5(      5)      5*      � 5+   
   $��2��6   
��� d �.+�5,      �� 
 �� Orientation$
 
Horizontal=�6   $��Right=�62   .+�5-      �� -   5        $��LoginBtn��5-      $��Login��6)   $��25��69   $��75��6E   $
��10,0q�6P   �� 5.      -   5        $��PurchaseBtn��5.      $��Purchase��6,   $��25��6?   $��75��6K   $
��10,0q�6V   �� 5/      -   5        $��	CancelBtn��5/      $��Cancel��6*   $��25��6;   $��75��6G   $��	10,0,25,0q�6R   50      52      53      54      