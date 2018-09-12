import { Injectable } from '@angular/core';

@Injectable()

export class AppConfig {
  
    private _config: { [key: string]: string };

    constructor() {
        this._config = { 
            //PathAPI: 'https://igniatechassessment.blob.core.windows.net/serverhosting/serverStatus.json'
            PathAPI: 'https://api.myjson.com/bins/7v1dk'
        };
    }

    get setting():{ [key: string]: string } {
        return this._config;
    }

    get(key: any) {
        return this._config[key];
    }
};