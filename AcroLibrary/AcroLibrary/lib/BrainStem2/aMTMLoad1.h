/////////////////////////////////////////////////////////////////////
//                                                                 //
// file: aMTMLoad1.h	 	  	                           //
//                                                                 //
/////////////////////////////////////////////////////////////////////
//                                                                 //
// description: BrainStem MTM-PM1 module object.                   //
//                                                                 //
// build number: source                                            //
//                                                                 //
/////////////////////////////////////////////////////////////////////
//                                                                 //
// Copyright (c) 2018 Acroname Inc. - All Rights Reserved          //
//                                                                 //
// This file is part of the BrainStem release. See the license.txt //
// file included with this package or go to                        //
// https://acroname.com/software/brainstem-development-kit         //
// for full license details.                                       //
/////////////////////////////////////////////////////////////////////

#ifndef __aMTMLoad1_H__
#define __aMTMLoad1_H__

#include "BrainStem-all.h"
#include "aProtocoldefs.h"

#define aMTMLOAD1_MODULE_BASE_ADDRESS                                14

#define aMTMLOAD1_NUM_APPS                                            4
#define aMTMLOAD1_NUM_DIGITALS                                        4
#define aMTMLOAD1_NUM_I2C                                             1
#define aMTMLOAD1_NUM_POINTERS                                        4
#define aMTMLOAD1_NUM_RAILS                                           1
#define   aMTMLOAD1_RAIL0                                             0
#define   aMTMLOAD1_MAX_MICROVOLTAGE                           32000000
#define   aMTMLOAD1_MIN_MICROVOLTAGE                                  0
#define   aMTMLOAD1_MAX_MICROAMPS                              11000000
#define   aMTMLOAD1_MIN_MICROAMPS                                     0
#define   aMTMLOAD1_MAX_MILLIWATTS                               150000
#define   aMTMLOAD1_MIN_MILLIWATTS                                    0
#define   aMTMLOAD1_MAX_MILLIOHMS                            1000000000
#define   aMTMLOAD1_MIN_MILLIOHMS                                     0
#define   aMTMLOAD1_MAX_VOLTAGE_LIMIT_MICROVOLTS               35000000
#define   aMTMLOAD1_MIN_VOLTAGE_LIMIT_MICROVOLTS                -700000
#define   aMTMLOAD1_MAX_CURRENT_LIMIT_MICROAMPS                12000000
#define   aMTMLOAD1_MIN_CURRENT_LIMIT_MICROAMPS                -1000000
#define   aMTMLOAD1_MAX_POWER_LIMIT_MILLIWATTS                   150000
#define   aMTMLOAD1_MIN_POWER_LIMIT_MILLIWATTS                        0

#define aMTMLOAD1_NUM_STORES                                          2
#define   aMTMLOAD1_NUM_INTERNAL_SLOTS                               12
#define   aMTMLOAD1_NUM_RAM_SLOTS                                     1

#define aMTMLOAD1_NUM_TEMPERATURES                                    1
#define aMTMLOAD1_NUM_TIMERS                                          8



using Acroname::BrainStem::Module;
using Acroname::BrainStem::Link;
using Acroname::BrainStem::AppClass;
using Acroname::BrainStem::DigitalClass;
using Acroname::BrainStem::I2CClass;
using Acroname::BrainStem::PointerClass;
using Acroname::BrainStem::RailClass;
using Acroname::BrainStem::StoreClass;
using Acroname::BrainStem::SystemClass;
using Acroname::BrainStem::TemperatureClass;
using Acroname::BrainStem::TimerClass;



class aMTMLoad1 : public Module
{
public:

    aMTMLoad1(const uint8_t module = aMTMLOAD1_MODULE_BASE_ADDRESS,
            bool bAutoNetworking = true,
            const uint8_t model = aMODULE_TYPE_MTM_LOAD_1) :
    Module(module, bAutoNetworking, model)
    {
        app[0].init(this, 0);
        app[1].init(this, 1);
        app[2].init(this, 2);
        app[3].init(this, 3);

        digital[0].init(this, 0);
        digital[1].init(this, 1);
        digital[2].init(this, 2);
        digital[3].init(this, 3);

        i2c[0].init(this, 0);

        pointer[0].init(this, 0);
        pointer[1].init(this, 1);
        pointer[2].init(this, 2);
        pointer[3].init(this, 3);

        rail[0].init(this, 0);

        store[storeInternalStore].init(this, storeInternalStore);
        store[storeRAMStore].init(this, storeRAMStore);

        system.init(this, 0);

        temperature.init(this, 0);

        timer[0].init(this, 0);
        timer[1].init(this, 1);
        timer[2].init(this, 2);
        timer[3].init(this, 3);
        timer[4].init(this, 4);
        timer[5].init(this, 5);
        timer[6].init(this, 6);
        timer[7].init(this, 7);



    }

    AppClass app[aMTMLOAD1_NUM_APPS];
    DigitalClass digital[aMTMLOAD1_NUM_DIGITALS];
    I2CClass i2c[aMTMLOAD1_NUM_I2C];
    PointerClass pointer[aMTMLOAD1_NUM_POINTERS];
    RailClass rail[aMTMLOAD1_NUM_RAILS];
    StoreClass store[aMTMLOAD1_NUM_STORES];
    SystemClass system;
    TemperatureClass temperature;
    TimerClass timer[aMTMLOAD1_NUM_TIMERS];


};

#endif /* __aMTMLoad1_H__ */
