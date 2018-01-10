/// <reference path="../../../../node_modules/@types/jasmine/index.d.ts" />
import { TestBed, async, ComponentFixture, ComponentFixtureAutoDetect } from '@angular/core/testing';
import { BrowserModule, By } from "@angular/platform-browser";
import { FeatureLargeComponent } from './feature-large.component';

let component: FeatureLargeComponent;
let fixture: ComponentFixture<FeatureLargeComponent>;

describe('feature-large component', () => {
    beforeEach(async(() => {
        TestBed.configureTestingModule({
            declarations: [ FeatureLargeComponent ],
            imports: [ BrowserModule ],
            providers: [
                { provide: ComponentFixtureAutoDetect, useValue: true }
            ]
        });
        fixture = TestBed.createComponent(FeatureLargeComponent);
        component = fixture.componentInstance;
    }));

    it('should do something', async(() => {
        expect(true).toEqual(true);
    }));
});