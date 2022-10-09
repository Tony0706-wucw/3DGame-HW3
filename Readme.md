完成：

请用三种方法以上方法，实现物体的抛物线运动。 （如，修改Transform属性，使用向量Vector3的方法）

---

**Time.deltaTime** 理解 ：**完成上一帧所用的时间**

FPS:一秒执行多少帧

- update 是每帧执行一次，transform.Translate 写在 update 中
- transform.Translate(new Vector3(1,0,0)) 每帧向 x 轴正方向移动 1 个单位
- transform.Translate(new Vector3(1*Time.deltaTime,0,0)) 每秒向 x 轴正方向移动 1 个单位
- Time.deltaTime <1 ，也是不固定的 。
- 60FPS 的时候 Time.deltaTime=0.02s，transform.Translate(new Vector3(1*Time.deltaTime,0,0))=transform.Translate(new Vector3(0.02f,0,0))，即每帧移动 0.02 个单位，如果 FPS 不变的话，理论就是 60 帧移动了 1 个单位，而 60 帧所用的时间就是 1 秒。**所以，就是官方说的要让数值按照每秒多少进行变化时就把这个数值乘以 Time.deltaTime 就可以了**

---

transform.position可以直接设置物体的位置

Vector3.Right Returns a unit [Vector3](https://learn.microsoft.com/zh-cn/previous-versions/windows/xna/bb199670(v=xnagamestudio.41)) pointing to the right (1, 0, 0).

对于translate（a，b）函数，如果省略b，系统将把它缺省为space.self，意思是在自身坐标系进行a向量方向的移动，如果b为space.world，那么物体就在世界坐标系上进行a向量方向的移动。

Vector3 val= Vector3.Slerp(mStart, mEnd, t); 初始，重点，移动比率

启用重力作用

​    Rigidbody rb = gameObject.AddComponent<Rigidbody>();   

​    rb.useGravity=true;

​    // Give it a horizontal speed.

​    rb.velocity = Vector3.right * 4;//水平速度

