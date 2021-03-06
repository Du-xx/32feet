﻿//-----------------------------------------------------------------------
// <copyright file="BluetoothRemoteGATTService.standard.cs" company="In The Hand Ltd">
//   Copyright (c) 2018-20 In The Hand Ltd, All rights reserved.
//   This source code is licensed under the MIT License - see License.txt
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InTheHand.Bluetooth
{
    partial class GattService
    {
        BluetoothUuid GetUuid()
        {
            return default;
        }

        bool GetIsPrimary()
        {
            return true;
        }

        Task<GattCharacteristic> DoGetCharacteristic(BluetoothUuid characteristic)
        {
            return Task.FromResult((GattCharacteristic)null);
        }

        Task<IReadOnlyList<GattCharacteristic>> DoGetCharacteristics()
        {
            List<GattCharacteristic> characteristics = new List<GattCharacteristic>();

            return Task.FromResult((IReadOnlyList<GattCharacteristic>)characteristics.AsReadOnly());
        }

        private async Task<GattService> DoGetIncludedServiceAsync(BluetoothUuid service)
        {
            return null;
        }

        private async Task<IReadOnlyList<GattService>> DoGetIncludedServicesAsync()
        {
            return null;
        }
    }
}
