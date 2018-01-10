/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { ServiceListComponent } from './service-list.component';

let component: ServiceListComponent;
let fixture: ComponentFixture<ServiceListComponent>;

describe('service-list component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ ServiceListComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(ServiceListComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});