# Trigasion（暂定） 

`smite the enemy`

## simple-2D-action-game

> project for software engineering course


## the art resources:

https://assetstore.unity.com/packages/2d/characters/pixel-adventure-1-155360
https://assetstore.unity.com/packages/2d/characters/pixel-adventure-2-155418

## the learning resources:

https://www.bilibili.com/video/av64017079

## 编写说明：
1. fork到自己的仓库进行编写，编写完毕后通过pr整合（可以使用github桌面版）。

2. 参照当前项目内的assets来整理文件，地图资源放在Maps里，动画资源放在Animations里等等，不清楚的地方可以问。

3. 具体方法看学习教程，里面介绍的非常全面。

## 中期报告展示内容：
1. 完成一张地图的设计

2. 完成人物的运动，物体的交互

3. 完成开始界面的设计，以及场景的切换

# 开发日志记录
### v0.1
1. 添加了一个新的敌人： AngryPig  
   * 周期性地在两个地点之间巡逻（水平地面上）  
   * 受到各类攻击（包括从上方的坠落攻击时），会触发受伤动画（无敌），随后进入狂暴状态  
   * 在狂暴状态下，原有的移动速度上升  
   * 再次受到攻击后被消灭（同时不再进行物理模拟和碰撞检测）

2. 更新了一些组件  
3. 更新了一些素材属性  

### v0.2

1. 添加了一个新的敌人：Mushroom  
   * 会在一定范围内（水平）搜索玩家，若未搜索到则原地停止  
   * 搜索到玩家后会朝玩家方向移动，并且存在水平延时（Dash），同时也会确保不会跌落地面  
   * 未检测到玩家一段时间后会回到原来位置  
   * 可以被从上方的坠落攻击杀死  
2. 修改了AngryPig的碰撞体  
   * 修改了胶囊碰撞体的位置  
   * 在上方新增边缘碰撞体以检测跳跃攻击，跳跃攻击不会在只接触敌人侧面时生效了
   * 其他一些优化
3. 更新了一些素材属性  