using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

namespace HoloToolkit.Examples.Prototyping
{

    public class CycleTransform : CycleArray<Transform>
    {
        //Position
        public bool UseLocalPosition = false;
        private MoveToPosition mMoveTranslator;

        //Scale
        private Vector3 StartScale;
        private bool isFirstCall = true;
        private ScaleToValue mScaler;

        //Rotation
        public bool UseLocalRotation = false;
        private RotateToValue mRotation;

        protected override void Awake()
        {
            mMoveTranslator = GetComponent<MoveToPosition>();
            mScaler = GetComponent<ScaleToValue>();
            mRotation = GetComponent<RotateToValue>();

            base.Awake();
        }

        public override void SetIndex(int index)
        {
            base.SetIndex(index);
            Transform item = Array[Index];

            Quaternion rotation = Quaternion.identity; rotation.eulerAngles = item.eulerAngles;
            Vector3 position = item.position;
            Vector3 scale = item.localScale;

            //Use Move To Position
                if (mMoveTranslator != null)
                {
                    mMoveTranslator.ToLocalTransform = UseLocalPosition;
                    mMoveTranslator.TargetValue = position;
                    mMoveTranslator.StartRunning();
                }
                else
                {
                    if (UseLocalPosition)
                    {
                        TargetObject.transform.localPosition = position;
                    }
                    else
                    {
                        TargetObject.transform.position = position;
                    }
                }

            //Set The Rotation
                if (mRotation != null)
                {
                    mRotation.ToLocalTransform = UseLocalRotation;
                    mRotation.TargetValue = rotation;
                    mRotation.StartRunning();
                }
                else
                {
                    if (UseLocalRotation)
                    {
                        TargetObject.transform.localRotation = rotation;
                    }
                    else
                    {
                        TargetObject.transform.rotation = rotation;
                    }
                }

            //Set Scale
                if (isFirstCall)
                {
                    StartScale = TargetObject.transform.localScale;
                    isFirstCall = false;
                }

                //item = Current;

                if (mScaler != null)
                {
                    mScaler.TargetValue = scale;
                    mScaler.StartRunning();
                }
                else
                {
                    TargetObject.transform.localScale = scale;
                }
        }
    }
}
