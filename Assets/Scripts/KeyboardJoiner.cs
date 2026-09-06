using UnityEngine;
using UnityEngine.InputSystem;

public class KeyboardJoiner : MonoBehaviour
{
    void Update()
    {
        // เมื่อกดปุ่ม Spacebar บนคีย์บอร์ด
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // เช็กว่ามี Player Input Manager ในฉากไหม
            if (PlayerInputManager.instance != null)
            {
                // สั่ง Join คีย์บอร์ดสปอว์นตัวละครออกมาทันที!
                PlayerInputManager.instance.JoinPlayer(
                    playerIndex: -1,
                    splitScreenIndex: -1,
                    controlScheme: null,
                    pairWithDevice: Keyboard.current
                );

                Debug.Log("สั่ง Spawn Player จากคีย์บอร์ดเรียบร้อย!");
            }
        }
    }
}