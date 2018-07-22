import { Injectable } from '@angular/core';

@Injectable()
export class ConfigService {
	public serverApiUrl: string = 'http://localhost:5000';
}
