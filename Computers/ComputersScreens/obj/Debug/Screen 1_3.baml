   M S B A M L   `   `   `  ����c  _System.Windows.Interactivity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  5      u qMicrosoft.Expression.Prototyping.Interactivity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35�oclr-namespace:Microsoft.Expression.Prototyping.Behavior;assembly=Microsoft.Expression.Prototyping.Interactivity)Microsoft.Expression.Prototyping.Behavior 6]   L HComputers.Screens, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!   ComputersScreens.Screen_1_3   5      \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     8x,http://schemas.microsoft.com/winfx/2006/xaml    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5      \iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity    5      |pboclr-namespace:Microsoft.Expression.Prototyping.Behavior;assembly=Microsoft.Expression.Prototyping.Interactivity    6]   -   5          >�Name$  Screen_1_3_Name��5   �   $	��640��5	      $	��480��6    � 	Resources 5
       �� MergedDictionaries �� Source   ItemTemplate�� 5       5      �� 5      $ ProjectDataSources.xaml?�6   %�   &	        �� 5      .R�5      �� .+�5      �� $
��Left=�6&   $��64��6A   $��64��6M   ��6   �� *Image+6M   �� 5      ��6   �� *Name+�� 5      ��6   �� *Price+5      5      5      .��5      � -   5         �Name$ 
LayoutRoot��5      
������� � DataContext 6/   ��   
DataSource �� Source# [ .+�5      �� $
��Left=�6   $��80,30.4,0,0q�6&   $	��122��6;   $��Orders��6G   $��18.667(�6X   $	��Top=�6j   $
��53.2��6�   ��5      �� 5       �� EndPoint$	 0,1&�6    �� 
StartPoint$	 0,0&�6)   .��5      � 	 � Color$	 	#FFF3F3F3��6   
 � Offset$
 0Q�6&   � 5      $	 	#FFEBEBEB��6   $	
 0.5Q�6&   � 5      $	 	#FFDDDDDD��6   $	
 0.5Q�6&   � 5       $	 	#FF6CEA00��6   $
 1Q�6&   5!      .   (System.Windows.Interactivity.Interaction   Triggers 5#      /   )System.Windows.Interactivity.EventTrigger  5$         	EventName$ Click��6   .   (System.Windows.Interactivity.TriggerBase   Actions. 5%      F  @Microsoft.Expression.Prototyping.Behavior.NavigateToScreenAction     TargetScreen$! ComputersScreens.Screen_1_3��6!   5&      5(      �� 5)      $��236.7,30.4,281.3,0q�6   $��Owner��6'   $��18.667(�67   $	��Top=�6I   $
��53.2��6a   
���  �� 5*        5+      $ Click��6   . 5,        $! ComputersScreens.Screen_1_4��6!   5-      5/      �� 50      $��Right=�6   $��0,30.4,136,0q�6'   $	��122��6=   $��Computer
components��6I   $��18.667(�6k   $	��Top=�6}   $
��53.2��6�   ��51      �� 52      $	 0,1&�6   $	 0,0&�6)   .��53      � $	 	#FFF3F3F3��6   $
 0Q�6&   � 54      $	 	#FFEBEBEB��6   $	
 0.5Q�6&   � 55      $	 	#FFDDDDDD��6   $	
 0.5Q�6&   � 56      $	 	#FF7400FF��6   $
 1Q�6&   57       59        5:      $ Click��6   . 5;        $! ComputersScreens.Screen_1_5��6!   5<      5>      �� 5?      $��236.7,99.2,281.3,0q�6   $��Welcome��6'   $��18.667(�69   $	��Top=�6K   $
��53.2��6c   ���	#FF3C00FF 5@        5A      $ Click��6   . 5B        $! ComputersScreens.Screen_1_1��6!   5C      5E      �� 5F      $��80,184,104,100q�6   #���   6$   ��6R   �� *
Collection+5G      5H      