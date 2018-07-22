import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpModule } from '@angular/http';

import { environment } from 'environments/environment';
import { AppComponent } from './app.component';
import { AppState } from './app.service';

import { ResponseErrorHandlerService } from './shared/services/response-error-handler-service';
import { HttpHelperService } from './shared/services/http-helper.service';
import { ConfigService } from './shared/services/config.service';
import { NotFoundComponent } from './layout/not-found/not-found.component';
import { AppRouterModule } from './app.router.module';

import '../styles/styles.scss';
import '../styles/headings.css';

const APP_PROVIDERS = [
	AppState
];

@NgModule({
	bootstrap: [AppComponent],
	declarations: [
		AppComponent,
		NotFoundComponent
	],
	imports: [
		BrowserModule,
		BrowserAnimationsModule,
		HttpClientModule,
		HttpModule,
		AppRouterModule
	],
	providers: [
		environment.ENV_PROVIDERS,
		APP_PROVIDERS,
		ResponseErrorHandlerService,
		HttpHelperService,
		ConfigService
	]
})
export class AppModule { }
