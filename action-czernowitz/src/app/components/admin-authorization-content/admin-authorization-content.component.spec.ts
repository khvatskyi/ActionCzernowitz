import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminAuthorizationContentComponent } from './admin-authorization-content.component';

describe('AdminAuthorizationContentComponent', () => {
  let component: AdminAuthorizationContentComponent;
  let fixture: ComponentFixture<AdminAuthorizationContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminAuthorizationContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminAuthorizationContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
