﻿using System;
using Hide.ScriptableObjects;
using Hide.System;
using Mirror;
using UnityEngine;

namespace Hide.Network
{
    /// <summary>
    /// The player character with data synced between each clients
    /// </summary>
    // public class HidePlayer : PlayerBehavior
    public class HidePlayer : NetworkBehaviour
    {
        public GameSceneData gameSceneData;
        public GameObject playerControllerPrefab;
        
        private GameLogic _gameLogic;
        private ExternalInput _externalInput;
        private HidePawn _pawnBody;

        private void Start()
        {
            Debug.Assert(gameSceneData != null);
        }

        public override void OnStartLocalPlayer()
        {
            base.OnStartLocalPlayer();
        
            _externalInput = gameSceneData.externalInput;
            _pawnBody = GetComponent<HidePawn>();
            _externalInput.Possess(_pawnBody);
        
            // todo: tell camera to follow me
        }

        /*
        protected override void NetworkStart()
        {
            base.NetworkStart();
            
            // If this networkObject is actually the **enemy** Player   
            // hence not the one we will control and own
            if (networkObject.IsOwner)
            {
                _externalInput = Instantiate(playerControllerPrefab).GetComponent<ExternalInput>();
                _pawnBody = GetComponent<HidePawn>();
                _externalInput.Possess(_pawnBody);
            }
        }

        private void Update()
        {
            if (!networkObject.IsOwner)
            {
                transform.position = networkObject.position;
                return;
            }

            networkObject.position = transform.position;
        }

        public override void UpdateName(RpcArgs args)
        {
            // ignore the method name for now
            // todo: check player info then send back who they are via RPC
            networkObject.SendRpc(args.Info.SendingPlayer, RPC_UPDATE_NAME, "");
        }*/
    }
}