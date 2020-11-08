/*
 * ExternalReceiver
 * https://sabowl.sakura.ne.jp/gpsnmeajp/
 *
 * MIT License
 * 
 * Copyright (c) 2020 gpsnmeajp
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ludiq;
using Bolt;

namespace EVMC4U
{
    public class InputReceiverForBolt : MonoBehaviour
    {
        public InputReceiver receiver;

        public Vector2 PositionTrackpad_Left;
        public Vector2 PositionTrackpad_Right;
        public Vector2 PositionThumbStick_Left;
        public Vector2 PositionThumbStick_Right;
        public float PullTrigger_Left;
        public float PullTrigger_Right;
        public float PullGrip_Left;
        public float PullGrip_Right;
        public bool ClickSystem_Left;
        public bool ClickSystem_Right;
        public bool TouchSystem_Left;
        public bool TouchSystem_Right;
        public bool ClickTrigger_Left;
        public bool ClickTrigger_Right;
        public bool TouchTrigger_Left;
        public bool TouchTrigger_Right;
        public bool TouchTrackpad_Left;
        public bool TouchTrackpad_Right;
        public bool ClickThumbStick_Left;
        public bool ClickThumbStick_Right;
        public bool TouchThumbStick_Left;
        public bool TouchThumbStick_Right;
        public bool ClickBbutton_Left;
        public bool ClickBbutton_Right;
        public bool TouchBbutton_Left;
        public bool TouchBbutton_Right;
        public bool ClickAbutton_Left;
        public bool ClickAbutton_Right;
        public bool TouchAbutton_Left;
        public bool TouchAbutton_Right;
        public bool ClickGrip_Left;
        public bool ClickGrip_Right;
        public bool TouchGrip_Left;
        public bool TouchGrip_Right;
        public bool ClickXbutton_Left;
        public bool ClickXbutton_Right;
        public bool TouchXbutton_Left;
        public bool TouchXbutton_Right;
        public bool ClickYbutton_Left;
        public bool ClickYbutton_Right;
        public bool TouchYbutton_Left;
        public bool TouchYbutton_Right;
        public bool ClickTrackpad_Left;
        public bool ClickTrackpad_Right;
        public bool ClickMenu_Left;
        public bool ClickMenu_Right;


        private void Start()
        {
            receiver.ControllerInputAction.AddListener(ControllerInputEvent);
        }

        private void ControllerInputEvent(EVMC4U.ControllerInput con)
        {
            CustomEvent.Trigger(this.gameObject, "EVMC4U_ControllerInputEvent", con);

            if (con.name == "PositionTrackpad") { if (con.IsLeft == 1) { PositionTrackpad_Left = new Vector2(con.Axis.x, con.Axis.y); } else { PositionTrackpad_Right = new Vector2(con.Axis.x, con.Axis.y); } }
            if (con.name == "PositionThumbStick") { if (con.IsLeft == 1) { PositionThumbStick_Left = new Vector2(con.Axis.x, con.Axis.y); } else { PositionThumbStick_Right = new Vector2(con.Axis.x, con.Axis.y); } }
            if (con.name == "PullTrigger") { if (con.IsLeft == 1) { PullTrigger_Left = con.Axis.x; } else { PullTrigger_Right = con.Axis.x; } }
            if (con.name == "PullGrip") { if (con.IsLeft == 1) { PullGrip_Left = con.Axis.x; } else { PullGrip_Right = con.Axis.x; } }
            if (con.name == "ClickSystem") { if (con.IsLeft == 1) { ClickSystem_Left = con.active == 1; } else { ClickSystem_Right = con.active == 1; } }
            if (con.name == "TouchSystem") { if (con.IsLeft == 1) { TouchSystem_Left = con.active == 1; } else { TouchSystem_Right = con.active == 1; } }
            if (con.name == "ClickTrigger") { if (con.IsLeft == 1) { ClickTrigger_Left = con.active == 1; } else { ClickTrigger_Right = con.active == 1; } }
            if (con.name == "TouchTrigger") { if (con.IsLeft == 1) { TouchTrigger_Left = con.active == 1; } else { TouchTrigger_Right = con.active == 1; } }
            if (con.name == "TouchTrackpad") { if (con.IsLeft == 1) { TouchTrackpad_Left = con.active == 1; } else { TouchTrackpad_Right = con.active == 1; } }
            if (con.name == "ClickThumbStick") { if (con.IsLeft == 1) { ClickThumbStick_Left = con.active == 1; } else { ClickThumbStick_Right = con.active == 1; } }
            if (con.name == "TouchThumbStick") { if (con.IsLeft == 1) { TouchThumbStick_Left = con.active == 1; } else { TouchThumbStick_Right = con.active == 1; } }
            if (con.name == "ClickBbutton") { if (con.IsLeft == 1) { ClickBbutton_Left = con.active == 1; } else { ClickBbutton_Right = con.active == 1; } }
            if (con.name == "TouchBbutton") { if (con.IsLeft == 1) { TouchBbutton_Left = con.active == 1; } else { TouchBbutton_Right = con.active == 1; } }
            if (con.name == "ClickAbutton") { if (con.IsLeft == 1) { ClickAbutton_Left = con.active == 1; } else { ClickAbutton_Right = con.active == 1; } }
            if (con.name == "TouchAbutton") { if (con.IsLeft == 1) { TouchAbutton_Left = con.active == 1; } else { TouchAbutton_Right = con.active == 1; } }
            if (con.name == "ClickGrip") { if (con.IsLeft == 1) { ClickGrip_Left = con.active == 1; } else { ClickGrip_Right = con.active == 1; } }
            if (con.name == "TouchGrip") { if (con.IsLeft == 1) { TouchGrip_Left = con.active == 1; } else { TouchGrip_Right = con.active == 1; } }
            if (con.name == "ClickXbutton") { if (con.IsLeft == 1) { ClickXbutton_Left = con.active == 1; } else { ClickXbutton_Right = con.active == 1; } }
            if (con.name == "TouchXbutton") { if (con.IsLeft == 1) { TouchXbutton_Left = con.active == 1; } else { TouchXbutton_Right = con.active == 1; } }
            if (con.name == "ClickYbutton") { if (con.IsLeft == 1) { ClickYbutton_Left = con.active == 1; } else { ClickYbutton_Right = con.active == 1; } }
            if (con.name == "TouchYbutton") { if (con.IsLeft == 1) { TouchYbutton_Left = con.active == 1; } else { TouchYbutton_Right = con.active == 1; } }
            if (con.name == "ClickTrackpad") { if (con.IsLeft == 1) { ClickTrackpad_Left = con.active == 1; } else { ClickTrackpad_Right = con.active == 1; } }
            if (con.name == "ClickMenu") { if (con.IsLeft == 1) { ClickMenu_Left = con.active == 1; } else { ClickMenu_Right = con.active == 1; } }

        }
    }
}

/*
SkeletonLeftHand
SkeletonRightHand
PositionTrackpad
PositionThumbStick
PullTrigger
PullGrip
ClickSystem
TouchSystem
ClickTrigger
TouchTrigger
TouchTrackpad
ClickThumbStick
TouchThumbStick
ClickBbutton
TouchBbutton
ClickAbutton
TouchAbutton
ClickGrip
TouchGrip
ClickXbutton
TouchXbutton
ClickYbutton
TouchYbutton
ClickTrackpad
ClickMenu
*/